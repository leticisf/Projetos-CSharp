using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Qual é o seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Quantos anos você tem?");
        string idadeTexto = Console.ReadLine();
        int idade = int.Parse(idadeTexto);

        Console.WriteLine($"Prazer, {nome}! Você tem {idade} anos.");
    }
}

