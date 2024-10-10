using System;

class Exercicio5
{
static void Main(string[] args){

     bool completouEnsinoMédio = true;
     int idade = 19;
     bool maiorIdade = idade >= 18;
     bool OutraFaculdade = false;

     Console.WriteLine("Para poder crescer na vida mesmo que contra sua vontade, você precisa entrar em uma faculdade, para isso você precisa ter 18 anos ou mais, você tambem precisa ter ensino médio completo e não estar em outra faculdade");
     Console.WriteLine("Você completou ensino médio: {completouEnsinoMédio}");
     Console.WriteLine("Você é maior de idade: {maiorIdade}");
     Console.WriteLine("Você está em outra faculdade: {OutraFaculdade}");
  }
}