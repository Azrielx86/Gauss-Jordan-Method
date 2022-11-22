using System.Text;

namespace Gauss_Jordan_Method
{
	public class Matrix
	{
		public Matrix(double[,] matrix, double[] results)
		{
			MainMatrix = matrix;
			Results = results;
			Determinant = GetDeterminant();
			Variables = InitVariables();
		}

		public Matrix(Matrix matrix)
		{
			MainMatrix = matrix.CopyMatrix();
			Results = matrix.CopyResultVector();
			Determinant = GetDeterminant();
			Variables = matrix.CopyVariables();
		}

		public Matrix()
		{
		}

		public double[,] MainMatrix { get; set; }
		public double[] Results { get; set; }
		public double Determinant { get; private set; }
		public int Size { get => MainMatrix.GetLength(0); }
		public readonly List<string> Variables;

		public double this[int row, int col]
		{
			get
			{
				if (col > this.Size - 1 && col == this.Size)
					return Results[row];
				return MainMatrix[row, col];
			}
			set
			{
				if (col > this.Size - 1 && col == this.Size)
				{
					Results[row] = value;
					return;
				}
				MainMatrix[row, col] = value;
			}
		}

		private List<string> InitVariables()
		{
			var variables = new List<string>();
			for (int i = 0; i < Size; i++)
			{
				variables.Add($"x{i}");
			}
			return variables;
		}

		private List<string> CopyVariables() => Variables is null ? InitVariables() : new(Variables);

		private double GetDeterminant()
		{
			if (MainMatrix is null) return 0;
			int n = MainMatrix.GetLength(0);
			double[,] mat = CopyMatrix();

			double num1, num2, total = 1, det = 1;
			int index;

			double[] temp = new double[n + 1];

			for (int i = 0; i < n; i++)
			{
				index = i;

				while (index < n && mat[index, i] == 0)
				{
					index++;
				}

				if (index == n)
				{
					continue;
				}

				if (index != i)
				{
					for (int j = 0; j < n; j++)
						Swap(mat, index, j, i, j);

					det = (int)(det * Math.Pow(-1, index - i));
				}

				for (int j = 0; j < n; j++)
					temp[j] = mat[i, j];

				for (int j = i + 1; j < n; j++)
				{
					num1 = temp[i];
					num2 = mat[j, i];
					for (int k = 0; k < n; k++)
						mat[j, k] = (num1 * mat[j, k]) - (num2 * temp[k]);

					total *= num1;
				}
			}

			for (int i = 0; i < n; i++)
				det *= mat[i, i];

			return (det / total);
		}

		private double[,] CopyMatrix()
		{
			var n = MainMatrix.GetLength(0);
			var newMatrix = new double[n, n];

			for (int row = 0; row < MainMatrix.GetLength(0); row++)
			{
				for (int col = 0; col < MainMatrix.GetLength(1); col++)
				{
					newMatrix[row, col] = MainMatrix[row, col];
				}
			}

			return newMatrix;
		}

		private double[] CopyResultVector()
		{
			var vec = new double[Results.Length];
			for (int i = 0; i < Results.Length; i++)
			{
				vec[i] = Results[i];
			}

			return vec;
		}
		private double[,] Swap(double[,] m, int i1, int j1, int i2, int j2)
		{
			(m[i2, j2], m[i1, j1]) = (m[i1, j1], m[i2, j2]);
			return m;
		}

		public void SwapRow(Matrix matrix, int a, int b)
		{
			var tempRow = new double[matrix.MainMatrix.GetLength(0)];
			double tempResultValue;
			for (int i = 0; i < matrix.MainMatrix.GetLength(0); i++)
			{
				tempRow[i] = matrix.MainMatrix[a, i];
				matrix.MainMatrix[a, i] = matrix.MainMatrix[b, i];
				matrix.MainMatrix[b, i] = tempRow[i];
			}

			tempResultValue = matrix.Results[a];
			matrix.Results[a] = matrix.Results[b];
			matrix.Results[b] = tempResultValue;
		}

		public void SwapColumn(Matrix matrix, int a, int b)
		{
			var tempColumn = new double[matrix.MainMatrix.GetLength(0)];
			for (int i = 0; i < matrix.MainMatrix.GetLength(0); i++)
			{
				tempColumn[i] = matrix.MainMatrix[i, a];
				matrix.MainMatrix[i, a] = matrix.MainMatrix[i, b];
				matrix.MainMatrix[i, b] = tempColumn[i];
			}

			(Variables[b], Variables[a]) = (Variables[a], Variables[b]);
		}

		public override string ToString()
		{
			StringBuilder sb = new();

			for (int row = 0; row < MainMatrix.GetLength(0); row++)
			{
				for (int col = 0; col < MainMatrix.GetLength(1); col++)
				{
					if (MainMatrix[row, col] >= 0 && col > 0)
						sb.Append("+");

					sb.Append($" {MainMatrix[row, col]:00.00} ");
				}

				sb.Append($"= {Results[row]}");

				sb.AppendLine();
			}

			sb.AppendLine($"Determinant: {Determinant}");

			return sb.ToString();
		}
	}
}