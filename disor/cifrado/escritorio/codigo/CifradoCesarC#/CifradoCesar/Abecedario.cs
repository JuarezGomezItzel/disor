using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class Abecedario
    {
		char[] abec = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
								  'm', 'n' ,'o','p','q','r','s','t','u','v','w','x','y','z',
								  'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
								  'M', 'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
								};

		public char[] abecedario() {
             return abec;
        }

		public Boolean EsCaracter(char caracter)
		{
			Boolean bandera = false;
			for (int indice = 0; indice < abec.Length; indice++)
			{
				if (caracter == abec[indice])
				{
					return true;
				}
			}
			return bandera;
		}

	}
}
