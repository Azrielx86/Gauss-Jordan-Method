namespace Gauss_Jordan_Method
{
	public partial class GaussJordanSolver : Form
	{
		private Matrix _matrix;
		double matrix_size;
		public GaussJordanSolver(Matrix matrix)
		{
			InitializeComponent();
			_matrix = matrix;
			if (_matrix == null) throw new ArgumentNullException();

			label_determinant.Text = $"El determinante es: {_matrix.Determinant}";
			matrix_size = _matrix.MainMatrix.GetLength(0);

			ResizeMatrix();
			SolveMatrix();
		}

		private void SetMatrix(Matrix matrix)
		{
			matrix_size = matrix.MainMatrix.GetLength(0);

			for (int row = 0; row < matrix.MainMatrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.MainMatrix.GetLength(1); col++)
				{
					matrix_table.Rows[row].Cells[col].Value = matrix.MainMatrix[row, col];
				}
			}

			for (int row = 0; row < matrix.Results.GetLength(0); row++)
				result_matrix.Rows[row].Cells[0].Value = matrix.Results[row];
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
			var solvedMatrix = _matrix.GaussJordanSolve();	
			if (solvedMatrix == null) return;
			SetMatrix(solvedMatrix);
		}

		private void OnExitClicked(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}