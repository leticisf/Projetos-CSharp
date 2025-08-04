using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Unidades");
        Console.WriteLine("---------------------");

        Console.Write("Digite o valor a ser convertido: ");
        string entrada = Console.ReadLine();
        double valor;

        if (!double.TryParse(entrada, out valor) || valor < 0)
        {
            Console.WriteLine("Valor inválido!");
            return;
        }

        Console.WriteLine("Escolha a conversão:");
        Console.WriteLine("1 - Metros para Km");
        Console.WriteLine("2 - Km para Metros");
        Console.WriteLine("3 - Km para Milhas");
        Console.WriteLine("4 - Milhas para Km");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        double resultado = 0;
        bool valido = true;

        switch (opcao)
        {
            case "1":
                resultado = valor / 1000;
                Console.WriteLine($"{valor} metros = {resultado} km");
                break;
            case "2":
                resultado = valor * 1000;
                Console.WriteLine($"{valor} km = {resultado} metros");
                break;
            case "3":
                resultado = valor * 0.621371;
                Console.WriteLine($"{valor} km = {resultado:F2} milhas");
                break;
            case "4":
                resultado = valor / 0.621371;
                Console.WriteLine($"{valor} milhas = {resultado:F2} km");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                valido = false;
                break;
        }
    }
}
