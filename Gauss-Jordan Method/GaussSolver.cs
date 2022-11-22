namespace Gauss_Jordan_Method
{
	public class GaussSolver
	{
		public readonly Matrix ToSolve;
		public readonly List<double> Pivots;
		public readonly List<Matrix> Historical;
		private readonly int _size;

		public GaussSolver(Matrix matrix)
		{
			ToSolve = matrix;
			Pivots = new();
			Historical = new()
			{
				new Matrix(matrix)
			};
			_size = matrix.MainMatrix.GetLength(0);
		}

		public void Solve() => GaussJordanSolution();

		private void GaussJordanSolution()
		{
			if (ToSolve.Determinant == 0) throw new DeterminantZeroException();

			for (int i = 0; i < ToSolve.Size; i++)
			{
				double max = Math.Abs(ToSolve[i, i]);
				int[] indexes = new int[] { -1, -1 };
				for (int row = i; row < _size; row++)
				{
					for (int col = i; col < _size; col++)
					{
						if (Math.Abs(ToSolve[row, col]) > max)
						{
							max = Math.Abs(ToSolve[row, col]);
							indexes[0] = row;
							indexes[1] = col;
						}
					}
				}

				if (indexes[0] != -1 && indexes[1] != -1)
					Pivots.Add(ToSolve[indexes[0], indexes[1]]);
				else
					Pivots.Add(ToSolve[i, i]);

				if (indexes[0] != -1 && indexes[1] != -1)
				{
					ToSolve.SwapRow(ToSolve, i, indexes[0]);
					ToSolve.SwapColumn(ToSolve, i, indexes[1]);
				}

				indexes[0] = i;
				indexes[1] = i;

				max = ToSolve[indexes[0], indexes[1]];

				for (int nCol = 0; nCol < ToSolve.Size; nCol++)
				{
					ToSolve[indexes[0], nCol] /= max;
				}
				ToSolve[indexes[0], ToSolve.Size] /= max;

				for (int sRow = 0; sRow < ToSolve.Size; sRow++)
				{
					if (sRow == indexes[0]) continue;
					double anulator = ToSolve[sRow, i];
					for (int sCol = 0; sCol < ToSolve.Size; sCol++)
					{
						ToSolve[sRow, sCol] -= anulator * ToSolve[indexes[0], sCol];
					}
					ToSolve[sRow, ToSolve.Size] -= anulator * ToSolve[indexes[0], ToSolve.Size];
				}

				Historical.Add(new Matrix(ToSolve));
			}
		}
	}

	public class DeterminantZeroException : Exception
	{
		public override string Message => "Determinant is equal to zero, the solution doesn't exists.";
	}
}