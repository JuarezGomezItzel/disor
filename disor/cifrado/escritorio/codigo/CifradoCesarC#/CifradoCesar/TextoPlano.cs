using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class TextoPlano
    {
        char[] caracteres;
        public char[] textoplano (String texto) {
            for (int indice = 0; indice < texto.Length;indice++ )
            {
                caracteres[indice] = texto[indice];
            }
            return caracteres;
  
        }
    }

    
}
