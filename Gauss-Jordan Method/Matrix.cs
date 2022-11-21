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
		}

		public double[,] MainMatrix { get; set; }
		public double[] Results { get; set; }
		public double Determinant { get; private set; }

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

		private double[,] Swap(double[,] arr, int i1, int j1, int i2, int j2)
		{
			(arr[i2, j2], arr[i1, j1]) = (arr[i1, j1], arr[i2, j2]);
			return arr;
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

		public Matrix GaussJordanSolve()
		{
			Matrix result = new(CopyMatrix(), CopyResultVector());
			// Pivoteo, for externo para cada diagonal
			for (int row = 0; row < MainMatrix.GetLength(0); row++)
			{
				// Columna n, obtención del valor más alto
				double max = 0;
				int maxIndex = 0;
				for (int col = MainMatrix.GetLength(0) - 1; col >= row; col--)
				{
					double temp = Math.Abs(result.MainMatrix[col, row]);
					if (temp > max)
					{
						max = temp;
						maxIndex = col;
					}
				}

				max = result.MainMatrix[maxIndex, row];

				if (row != maxIndex)
				{
					SwapRow(result, row, maxIndex);
					maxIndex = row;
				}

				// Dividiendo fila entre el máximo
				for (int j = 0; j < MainMatrix.GetLength(0); j++)
				{
					result.MainMatrix[maxIndex, j] /= max;
				}
				result.Results[maxIndex] /= max;

				// Resolviendo ceros
				for (int i = 0; i < MainMatrix.GetLength(0); i++)
				{
					if (i == maxIndex) continue;
					// Haciendo ceros
					for (int j = 0; j < MainMatrix.GetLength(0); j++)
					{
						result.MainMatrix[i, j] -= result.MainMatrix[i, j] * result.MainMatrix[maxIndex, j];
					}
					result.Results[i] -= result.Results[i] * result.Results[maxIndex];
				}

				// Restaurando ceros positivos
				for (int j = 0; j < MainMatrix.GetLength(0); j++)
				{
					if (result.MainMatrix[maxIndex, j] == -0)
						result.MainMatrix[maxIndex, j] = Math.Abs(result.MainMatrix[maxIndex, j]);
				}
			}

			// TODO
			return result;
		}

		private void SwapRow(Matrix matrix, int a, int b)
		{
			var temp = new double[matrix.MainMatrix.GetLength(0)];
			double resultValue;
			for (int i = 0; i < matrix.MainMatrix.GetLength(0); i++)
			{
				temp[i] = matrix.MainMatrix[a, i];
				matrix.MainMatrix[a, i] = matrix.MainMatrix[b, i];
				matrix.MainMatrix[b, i] = temp[i];
			}

			resultValue = matrix.Results[a];
			matrix.Results[a] = matrix.Results[b];
			matrix.Results[b] = resultValue;
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