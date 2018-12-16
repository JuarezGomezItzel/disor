using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegovida
{
	public partial class Form1 : Form
	{
		bool[,] plano;
		int almacenamiento = 10;
		bool dibujo = false;
		bool colordibujo = false;
		public Form1()
		{
			InitializeComponent();
			irPlano();
		}

		private void irPlano()
		{
			//inicializacion del plano y tres celualas
			// x , y
			plano = new bool[50, 50]; // cuantas cuadros habra en el plano 
			plano[22, 12] = true;
			plano[22, 13] = true;
			plano[22, 14] = true;
			plano[21, 13] = true;
			plano[23, 13] = true;
			//plano[23, 14] = true;
			//pictureBox1.Size = new Size(plano.GetLength(0)*almacenamiento,plano.GetLength(1)*almacenamiento);
		}



		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			Graphics grafica = e.Graphics;
			Brush celulaviva = Brushes.White;
			Brush celulamuerta = Brushes.Black;
			for (int x = 0; x < plano.GetLength(0); x++)
			{
				for (int y=0; y < plano.GetLength(1);y++)
				{
					Brush b;
					if (plano[x,y])
					
						b = celulaviva;
					
					else
					
						b = celulamuerta;
					grafica.FillRectangle(b,x*almacenamiento,y*almacenamiento,almacenamiento,almacenamiento);
					
				}

			}

		}//fin metodo

		private void Iniciar_Click(object sender, EventArgs e)
		{
			//timer1.Stop();

			paso();

		}
		private void paso()
		{
			Vecinos vecinos = new Vecinos();
			plano = vecinos.SiguienteGeneracion(plano);
			pictureBox1.Invalidate();
		}

	
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			int x = e.X / almacenamiento;
			int y = e.Y / almacenamiento;
			dibujo = true;
			colordibujo = !plano[x, y];
			plano[x, y] = !plano[x, y];
			pictureBox1.Invalidate();
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (!dibujo)
				return;

			int x = e.X / almacenamiento;
			int y = e.Y / almacenamiento;
			// con estos dos ifs aunque se salga del area de trabajo no marca error
			if (x < 0 || x >= plano.GetLength(0))
				return;
			if (y < 0 || y >= plano.GetLength(1))
				return;
			plano[x, y] = colordibujo;
			pictureBox1.Invalidate();
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			dibujo = false;
		}

		private void Detener_Click(object sender, EventArgs e)
		{
			//timer1.Start
			if (Detener.Text == "Iniciar")
			{
				timer1.Start();
				Detener.Text = "Pausa";
			}
			else
			{
				timer1.Stop();
				Detener.Text = "Iniciar";
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			paso();
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			timer1.Interval = trackBar1.Value;
		}

		private void Prueba_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
