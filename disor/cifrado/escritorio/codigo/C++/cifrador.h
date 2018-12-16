#ifndef CIFRADOR_H
#define CIFRADOR_H

#endif // CIFRADOR_H

#include <iostream>
#include "abecedario.cpp"
using namespace std;
class Cifrador
 {
public:
    int indice=0;
    char c;
  //char abecedario;
     char Cifrar(int desplazamiento,char caracter);
private:
   int  buscarPosicion(char caracter, char* abecedario);
     };


           char Cifrar(int desplazamiento,char caracter) {
             // Abecedario a= new Abecedario();
             char  abecedario[52]=Abecedario();
             return  abecedario[buscarPosicion(caracter,abecedario)+ desplazamiento];
          }


           int buscarPosicion(char caracter, char abecedario[]) {
              int posicion=0;
              for (int indice = 0; indice < abecedario.size();indice++ ){
                  if (caracter == abecedario[indice]){
                      posicion = indice;
                  }
              }
              return posicion;
          }


