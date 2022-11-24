using Gauss_Jordan_Method.Exceptions;

namespace Gauss_Jordan_Method
{

	public class GaussSolver
	{
		public readonly List<Matrix> Historical;
		public readonly List<double> Pivots;
		public readonly Matrix ToSolve;
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
			if (double.IsNaN(ToSolve.Determinant)) throw new DeterminantNaNException();

			for (int i = 0; i < ToSolve.Size; i++)
			{
				double max = Math.Abs(ToSolve[i, i]);
				int[] xy = new int[] { -1, -1 };
				for (int row = i; row < _size; row++)
				{
					for (int col = i; col < _size; col++)
					{
						if (Math.Abs(ToSolve[row, col]) > max)
						{
							max = Math.Abs(ToSolve[row, col]);
							xy[0] = row;
							xy[1] = col;
						}
					}
				}

				if (xy[0] != -1 && xy[1] != -1)
					Pivots.Add(ToSolve[xy[0], xy[1]]);
				else
					Pivots.Add(ToSolve[i, i]);

				if (xy[0] != -1 && xy[1] != -1)
				{
					ToSolve.SwapRow(ToSolve, i, xy[0]);
					ToSolve.SwapColumn(ToSolve, i, xy[1]);
				}

				xy[0] = i;
				xy[1] = i;

				max = ToSolve[xy[0], xy[1]];

				for (int nCol = 0; nCol < ToSolve.Size; nCol++)
				{
					ToSolve[xy[0], nCol] /= max;
				}
				ToSolve[xy[0], ToSolve.Size] /= max;

				for (int sRow = 0; sRow < ToSolve.Size; sRow++)
				{
					if (sRow == xy[0]) continue;
					double anulator = ToSolve[sRow, i];
					for (int sCol = 0; sCol < ToSolve.Size; sCol++)
					{
						ToSolve[sRow, sCol] -= anulator * ToSolve[xy[0], sCol];
					}
					ToSolve[sRow, ToSolve.Size] -= anulator * ToSolve[xy[0], ToSolve.Size];
				}

				Historical.Add(new Matrix(ToSolve));
			}
		}
	}
}