using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CifradoCesar
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		Cifrador cifrar = new Cifrador(); InvertirCadena inverso = new InvertirCadena();
		Abecedario abc = new Abecedario();
		private void SoltoTeclaTextoPlano(object sender, KeyEventArgs e){
            Cifrador cifrar = new Cifrador();
        }

        private void DesCesar_ValueChanged(object sender, EventArgs e) {
			Abecedario abc = new Abecedario();
			int indice = 0;
             String texto = "";
            while(indice < TextoPlano.Text.Length)
			{
				if (abc.EsCaracter(TextoPlano.Text[indice]) == true)
				{
					texto = texto + cifrar.Cifrar(Convert.ToInt16(DesCesar.Value), Convert.ToChar(TextoPlano.Text[indice]));
				}
				else
				{
					texto = texto+TextoPlano.Text[indice] ;
				}

				indice++;
            }
            TextoCifrado.Text = texto;
            TextoInverso.Text = inverso.invertirCadena(TextoPlano.Text);
            
        }



		private void TextoPlano_TextChanged(object sender, EventArgs e)
		{
			Cifrador cifrar = new Cifrador(); InvertirCadena inverso = new InvertirCadena();
			int indice = 0;
			Abecedario abc = new Abecedario();
			String texto = "";
			while (indice < TextoPlano.Text.Length)
			{
				if (abc.EsCaracter(TextoPlano.Text[indice]) == true)
				{
					texto = texto + cifrar.Cifrar(Convert.ToInt16(DesCesar.Value), Convert.ToChar(TextoPlano.Text[indice]));
				}
				else
				{
					texto = texto + TextoPlano.Text[indice];
				}

				indice++;
			}

			TextoCifrado.Text = texto;
			TextoInverso.Text = inverso.invertirCadena(TextoPlano.Text);
			TextoInvertidoGrupo invertirxgrupo = new TextoInvertidoGrupo();
			TextoInvertidoxGrupo.Text = invertirxgrupo.invertirCadena(TextoPlano.Text, Convert.ToInt16(DesGrupo.Value),0,"");
		}
        


        private void DesGrupo_ValueChanged(object sender, EventArgs e)
        {
            TextoInvertidoGrupo invertirxgrupo = new TextoInvertidoGrupo();
			TextoInvertidoxGrupo.Text= invertirxgrupo.invertirCadena(TextoPlano.Text,Convert.ToInt16(DesGrupo.Value),0,"");
		}

		private void TextoInvertidoxGrupo_TextChanged(object sender, EventArgs e)
		{
		}

	}
}
