using System.Text.RegularExpressions;

namespace Gauss_Jordan_Method
{
	public partial class ResultsWindow : Form
	{
		private readonly Matrix _matrix;
		private readonly GaussSolver solution;
		private double matrix_size;
		private int currentIndex;

		public ResultsWindow(Matrix matrix)
		{
			InitializeComponent();
			_matrix = matrix;
			if (_matrix == null) throw new ArgumentNullException();
			solution = new GaussSolver(_matrix);

			label_determinant.Text = $"El determinante es: {_matrix.Determinant}";
			matrix_size = _matrix.MainMatrix.GetLength(0);

			result_matrix.RowHeadersWidth = 50;
			result_matrix.EditingControlShowing += (sender, e) =>
			{
				if (e.Control is not TextBox tb) return;
				tb.KeyPress += (object? snd, KeyPressEventArgs kpe) =>
				{
					kpe.Handled = true;
				};
			};

			ResizeMatrix();
			SolveMatrix();
		}

		private void SetMatrix(Matrix matrix)
		{
			matrix_size = matrix.Size;

			for (int row = 0; row < matrix.MainMatrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.MainMatrix.GetLength(1); col++)
				{
					matrix_table.Rows[row].Cells[col].Value = matrix.MainMatrix[row, col];
				}
			}

			for (int row = 0; row < matrix.Results.GetLength(0); row++)
			{
				result_matrix.Rows[row].Cells[0].Value = matrix.Results[row];
				result_matrix.Rows[row].HeaderCell.Value = matrix.Variables[row];
			}
		}

		private void ResizeMatrix()
		{
			while (matrix_table.ColumnCount != matrix_size)
			{
				if (matrix_size > matrix_table.ColumnCount)
				{
					matrix_table.Columns.AddRange(new DataGridViewTextBoxColumn());
					matrix_table.Rows.Add();
					result_matrix.Rows.Add();
				}
				else
				{
					matrix_table.Rows.RemoveAt(matrix_table.Rows.Count - 1);
					matrix_table.Columns.RemoveAt(matrix_table.Columns.Count - 1);
					result_matrix.Rows.RemoveAt(result_matrix.Rows.Count - 1);
				}
			}
		}

		private void SolveMatrix()
		{
			solution.Solve();
			if (solution == null || solution.ToSolve == null) return;
			SetMatrix(solution.Historical.First());
			currentIndex = 0;
			lblPivot.Text = $"Pivote seleccionado: {solution.Pivots[0]}";
			btnPrev.Enabled = false;
			btnNext.Enabled = true;
		}

		private void OnExitClicked(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnNextClicked(object sender, EventArgs e)
		{
			SetMatrix(solution.Historical[++currentIndex]);
			if (currentIndex == solution.Historical.Count - 1)
			{
				lblPivot.Text = $"Solución final, producto de los pivotes: {solution.Pivots.Aggregate((p, n) => p * n)}";
				btnNext.Enabled = false;
				btnPrev.Enabled = true;
			}
			else
			{
				lblPivot.Text = $"Pivote seleccionado: {solution.Pivots[currentIndex]}";
				btnPrev.Enabled = true;
			}
		}

		private void OnPrevClicked(object sender, EventArgs e)
		{
			SetMatrix(solution.Historical[--currentIndex]);
			lblPivot.Text = $"Pivote seleccionado: {solution.Pivots[currentIndex]}";
			if (currentIndex == 0)
			{
				btnNext.Enabled = true;
				btnPrev.Enabled = false;
			}
			else
			{
				btnNext.Enabled = true;
			}
		}
	}
}