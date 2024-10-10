using System;

class Variaveis
{

    static void Main (string[])
    // Aqui, criei uma variavel de numero INTEIRO, com o valor 15
    int numero = 15;
    Console.WriteLine(numero);
    Console.WriteLine(numero + 30);
    Console.WriteLine(numero + 10);
    Console.WriteLine(numero + 90);

};

int idade = 25;          // numero inteiro
double altura = 1.75;     //Numero com ponto flutuante
char inicial = 'A';      //um unico caractere
string nome = "Carlos";  //Texto
bool aprovado = true;   //Verdadeiro ou falso


Console.WriteLine("Meu nome é {nome}.");

Console.WriteLine($"Meu nome é {nome}. Tenho {idade} anos. Minha altura é {altura}. Meu nome começa com a letra {inicial}. Estou aprovado na escola? {aprovado}.");


