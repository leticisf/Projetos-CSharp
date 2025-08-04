using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Contador de Palavras");
        Console.WriteLine("---------------------");

        // Pede ao usuário que digite uma frase
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        // Verifica se a entrada não está vazia ou nula
        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("Você não digitou nada!");
            return;
        }

        // Divide a frase em palavras com base nos espaços
        string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Mostra o número de palavras
        Console.WriteLine($"Número de palavras: {palavras.Length}");
    }
}
