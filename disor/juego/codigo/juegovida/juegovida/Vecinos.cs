using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegovida
{
	class Vecinos
	{
		public bool[,] SiguienteGeneracion(bool[,]plano)
		{
			bool[,] plann = new bool[plano.GetLength(0), plano.GetLength(1)];
			for (int x = 0; x < plano.GetLength(0); x++)
			{
				for (int y = 0; y < plano.GetLength(1); y++)
				{
					int vecino = getVecinosVivos(plano, x, y);
					if (plano[x, y])
					{
						plann[x, y] = (vecino >= 2 && vecino <= 3);
					}
					else
					{
						plann[x, y] = (vecino == 3);
					}
				}
			}
			return plann;
		}

		private int getVecinos(bool[,] plan, int x, int y)
		{
			int vecino = 0;
			int maxX = plan.GetLength(0);
			int maxY = plan.GetLength(1);
			for (int dx = -1; dx <= 1; dx++)
			{
				for (int dy = -1; dy <= 1; dy++)
				{
					int cx = x + dx;
					int cy = y + dy;
					if (cx == x && cy == y) continue;
					if (cx < 0 || cx >= maxX) continue;
					if (cy < 0 || cy >= maxY) continue;
					if (plan[cx, cy]) vecino++;

				}
			}
			return vecino;
		}


		private int getVecinosVivos(bool[,] plan, int x, int y)
		{
			int vecino = 0;
			int maxX = plan.GetLength(0);
			int maxY = plan.GetLength(1);
			for (int dx = -1; dx <= 1; dx++)
			{
				for (int dy = -1; dy <= 1; dy++)
				{
					int cx = x + dx;
					int cy = y + dy;
					if (cx == x && cy == y) continue;
					if (cx < 0 || cx >= maxX) continue;
					if (cy < 0 || cy >= maxY) continue;
					if (plan[cx, cy]) vecino++;

				}
			}
			return vecino;
		}

		
	}
}
