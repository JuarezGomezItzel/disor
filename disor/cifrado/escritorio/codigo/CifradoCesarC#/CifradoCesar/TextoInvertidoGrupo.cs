using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class TextoInvertidoGrupo
    {
        public String invertirCadena(String cadena,int NumeroGrupo,int posInicial, String NuevoTexto)
        {
			String texto= QuitarEspacio(cadena,0,"");
			InvertirCadena invertirCad = new InvertirCadena();
			int RecorrerCadenaGrupo = NumeroGrupo + posInicial;
			while (RecorrerCadenaGrupo <= texto.Length)
			{
				NuevoTexto = NuevoTexto + invertirCad.invertirCadena(texto.Substring(posInicial,NumeroGrupo));
				posInicial = posInicial + NumeroGrupo;
				RecorrerCadenaGrupo = RecorrerCadenaGrupo + NumeroGrupo;
			}
			
			if ((RecorrerCadenaGrupo-texto.Length) != NumeroGrupo ) {
				NuevoTexto = NuevoTexto + texto.Substring((RecorrerCadenaGrupo-NumeroGrupo),texto.Length-(RecorrerCadenaGrupo-NumeroGrupo));
			}
			
			return NuevoTexto;
		}

		private  string QuitarEspacio(string Cadena,int indice,String cadenaNueva)
		{
			Abecedario abc = new Abecedario();
			while (indice < Cadena.Length)
			{
				if (abc.EsCaracter(Cadena[indice]) == true)
				{
					cadenaNueva = cadenaNueva + Cadena[indice];
				}

				indice++;
			}

			return cadenaNueva;
		}
	}
}
