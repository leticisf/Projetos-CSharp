using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vinda ao Conversor de Moedas!");

        // Taxas de câmbio fixas para o exemplo (R$ para outras moedas)
        double dolar = 5.10;
        double euro = 5.60;
        double libra = 6.20;

        Console.Write("Digite o valor em reais (R$): ");
        string entrada = Console.ReadLine();
        double reais;

        if (!double.TryParse(entrada, out reais) || reais < 0)
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número positivo.");
            return;
        }

        Console.WriteLine("Escolha a moeda para conversão:");
        Console.WriteLine("1 - Dólar");
        Console.WriteLine("2 - Euro");
        Console.WriteLine("3 - Libra");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        double resultado = 0;
        bool opcaoValida = true;

        switch (opcao)
        {
            case "1":
                resultado = reais / dolar;
                break;
            case "2":
                resultado = reais / euro;
                break;
            case "3":
                resultado = reais / libra;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                opcaoValida = false;
                break;
        }

        if (opcaoValida)
        {
            Console.WriteLine($"Valor convertido: {resultado:F2}");
        }
    }
}
