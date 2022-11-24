using Gauss_Jordan_Method.Exceptions;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;

namespace Gauss_Jordan_Method
{
    public partial class MatrixCreator : Form
	{
		public MatrixCreator()
		{
			InitializeComponent();
			matrix_table.AutoGenerateColumns = true;
			ResizeMatrix();
		}

		private void ResizeMatrix()
		{
			while (matrix_table.ColumnCount != matrix_size.Value)
			{
				if (matrix_size.Value > matrix_table.ColumnCount)
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

		private void OnResizeMatrixChange(object sender, EventArgs e) => ResizeMatrix();

		private void ValidateIsNumber(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (e.Control is not TextBox tb) return;

			string prev = tb.Text;
			tb.KeyPress += (object? snd, KeyPressEventArgs kpe) =>
			{
				var reInput = new Regex(@"-|\d|\.|[\b]");
				var reTb = new Regex(@"^-{0,1}\d+\.{0,1}\d*$");

				if (!reInput.IsMatch(kpe.KeyChar.ToString()) && !reTb.IsMatch(tb.Text))
					kpe.Handled = true;
			};
		}

		private Matrix FormToMatrix()
		{
			double[,] matrix = new double[matrix_table.ColumnCount, matrix_table.RowCount];
			double[] results = new double[result_matrix.RowCount];

			for (int rows = 0; rows < matrix_table.Rows.Count; rows++)
			{
				for (int col = 0; col < matrix_table.Rows[rows].Cells.Count; col++)
				{
					var value = matrix_table.Rows[rows].Cells[col].Value ?? "0";
					matrix[rows, col] = double.Parse(value.ToString()!);
				}
			}

			for (int rows = 0; rows < result_matrix.Rows.Count; rows++)
			{
				var value = result_matrix.Rows[rows].Cells[0].Value ?? "0";
				results[rows] = double.Parse(value.ToString()!);
			}

			return new Matrix(matrix, results);
		}

		private void SaveToJson()
		{
			Matrix matrix = FormToMatrix();

			string json = JsonConvert.SerializeObject(matrix, Formatting.Indented) ?? "";
			var sfd = new SaveFileDialog
			{
				Filter = "JSON Files (*.json)|*.json|txt files (*.txt)|*.txt|All files (*.*)|*.*",
				AddExtension = true,
				FileName = "matriz_Gauss-Jordan"
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(sfd.FileName, json, Encoding.UTF8);
			}
		}

		private async void OpenJsonFile()
		{
			var ofd = new OpenFileDialog()
			{
				Filter = "JSON Files (*.json)|*.json|txt files (*.txt)|*.txt|All files (*.*)|*.*",
			};

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				Matrix? dataMatrix;
				string data;
				using (StreamReader sr = new(ofd.FileName, Encoding.UTF8))
					data = await sr.ReadToEndAsync();
				dataMatrix = JsonConvert.DeserializeObject<Matrix>(data);

				if (dataMatrix == null) return;

				matrix_size.Value = dataMatrix.MainMatrix.GetLength(0);
				ResizeMatrix();

				for (int row = 0; row < dataMatrix.MainMatrix.GetLength(0); row++)
				{
					for (int col = 0; col < dataMatrix.MainMatrix.GetLength(1); col++)
					{
						matrix_table.Rows[row].Cells[col].Value = dataMatrix.MainMatrix[row, col];
					}
				}

				for (int row = 0; row < dataMatrix.Results.GetLength(0); row++)
					result_matrix.Rows[row].Cells[0].Value = dataMatrix.Results[row];
			}
		}

		private void OnSaveClicked(object sender, EventArgs e) => SaveToJson();

		private void OnOpenClicked(object sender, EventArgs e) => OpenJsonFile();

		private void OnSolveClicked(object sender, EventArgs e)
		{
			//if (FormToMatrix().Determinant == 0)
			//{
			//	MessageBox.Show("El determinante es igual a cero");
			//	return;
			//}

			this.Hide();
			try
			{
				var solution = new ResultsWindow(FormToMatrix());
				solution.FormClosed += (s, args) =>
				{
					this.Show();
				};
				solution.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				this.Show();
			}
		}
	}
}