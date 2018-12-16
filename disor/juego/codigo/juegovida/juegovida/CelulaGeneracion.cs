using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegovida
{
	class CelulaGeneracion
	{
		public void paso(Vecinos vecino, bool[,]plano,PictureBox pictureBox1)
		{
			//Vecinos vecino = new Vecinos();
			plano = vecino.SiguienteGeneracion(plano);
			pictureBox1.Invalidate();
		}
	}
}
