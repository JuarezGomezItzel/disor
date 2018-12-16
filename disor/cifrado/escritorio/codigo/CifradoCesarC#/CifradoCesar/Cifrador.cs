using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class Cifrador
    {
         
       

          public char Cifrar(int desplazamiento,char caracter) {
              Abecedario a= new Abecedario(); 
              char[] abecedario = a.abecedario();
			return  abecedario[ buscarPosicion(caracter,abecedario)+ desplazamiento];      
          }


          private int buscarPosicion(char caracter, char[] abecedario) {
              int posicion=0;
              for (int indice = 0; indice < abecedario.Length;indice++ ){
                  if (caracter == abecedario[indice]){
                      posicion = indice;
                  }
              }
              return posicion;
          }

    }
}
