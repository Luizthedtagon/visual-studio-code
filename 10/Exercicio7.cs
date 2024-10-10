//Condicionais são estruturas que permitem que um bloco de código só seja executado SE obdecer una determinada cibdução

using System;

class Condicionais
{

static void Main(string[] args){
int hora = 6;

 if (hora >= 6 && hora <12){
    Console.WriteLine("É de manha.");
 } else if {hora >= 12 && hora < 18}{
    Console.WriteLine("É de tarde.");
 } else (hora >= 18 && hora <= 23){
   Console.WriteLine("É de noite.");
 } else {
    Console.WriteLine("É de madrugada.");
 }

 
  }
}