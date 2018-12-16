using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	Abecedario abc = new Abecedario();
	Cifrador cifrador = new Cifrador();
	InvertirCadena invertircadena = new InvertirCadena();


	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void TextoPlano_TextChanged(object sender, EventArgs e)
	{
		Cifrador cifrar = new Cifrador(); //InvertirCadena inverso = new InvertirCadena();
		int indice = 0;
		Abecedario abc = new Abecedario();
		String texto = "";
		

		while (indice < TextoPlano.Text.Length)
		{
			if (abc.EsCaracter(TextoPlano.Text[indice]) == true )
			{
				texto = texto + cifrar.Cifrar(Convert.ToInt16(DesCesar.SelectedValue), Convert.ToChar(TextoPlano.Text[indice]));
			}
			else
			{
				texto = texto + TextoPlano.Text[indice];
			}

			indice++;
		}

		TextoCifrado.Text = texto;
		TextoInvertido.Text = invertircadena.invertirCadena(TextoPlano.Text);
	}




	protected void DesCesar_SelectedIndexChanged(object sender, EventArgs e)
	{
		Abecedario abc = new Abecedario();
		int indice = 0;
		String texto = "";
		while (indice < TextoPlano.Text.Length)
		{
			if (abc.EsCaracter(TextoPlano.Text[indice]) == true)
			{
				texto = texto + cifrador.Cifrar(Convert.ToInt16(DesCesar.SelectedValue), Convert.ToChar(TextoPlano.Text[indice]));
			}
			else
			{
				texto = texto + TextoPlano.Text[indice];
			}

			indice++;
		}
		TextoCifrado.Text = texto;
		TextoInvertido.Text = invertircadena.invertirCadena(TextoPlano.Text);
	}

	protected void DesGrupo_SelectedIndexChanged(object sender, EventArgs e)
	{
		TextoInvertidoGrupo invertirxgrupo = new TextoInvertidoGrupo();
		TextoInvertidoxGrupo.Text = invertirxgrupo.invertirCadena(TextoPlano.Text, Convert.ToInt16(DesGrupo.SelectedValue) , 0, "");
	}
}




