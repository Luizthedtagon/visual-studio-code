using System;

class OperadoresLogicos
{
static void Main(string[] args){
      
      bool temCarteira = true;
      int idade = 29;
      bool maiorIdade = idade >= 18;

      Console.WriteLine("Para poder dirigir, uma pessoa precisa ter carteira e ter 18 anos ou mais.");
      Console.WriteLine("Você tem carteira: {temCarteira}");
       Console.WriteLine("Você é de maior: {maiorIdade}");

      Console.WriteLine(temCarteira == true && maiorIdade == true);

      true %% true // true
      true && false // false
      false && false // false
      false && true // false






      // OPERADOR LÓGICO O (OR): retorna false apenas se todos forem false, apenas um único true já é o suficiente para que a equação retorne true.

      bool TemTrabalho = true;
      bool economiza = true;
      bool investe = true;

      bool nasceHerdeiro = false;

      (TemTrabalho && economiza && investe) || nasceHerdeiro;

     /*
        true || true // false
        true || false // true
        false || true // true
        false || false // false      
     */

     // OPERADOR LÓGICO NÃO/NEGAÇÃO (NOT): Inverte o estado. Se algo retorna true, ele transforma em false e vice-versa

       !true //false
       !false //true
       bool ligado = true;
       Console.WriteLine(ligado);

  }
}
