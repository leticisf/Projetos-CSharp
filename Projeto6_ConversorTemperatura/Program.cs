using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vinda ao Conversor de Temperatura!");

        while (true)
        {
            Console.WriteLine("\nEscolha a opção:");
            Console.WriteLine("1 - Converter Celsius para Fahrenheit");
            Console.WriteLine("2 - Converter Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");

            string opcao = Console.ReadLine()?.Trim();

            if (opcao == "3")
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }

            Console.Write("Digite a temperatura que deseja converter: ");
            string entradaTemp = Console.ReadLine()?.Trim();
            double temperatura;

            if (!double.TryParse(entradaTemp, out temperatura))
            {
                Console.WriteLine("Temperatura inválida. Tente novamente.");
                continue;
            }

            if (opcao == "1")
            {
                double fahrenheit = (temperatura * 9 / 5) + 32;
                Console.WriteLine($"{temperatura}°C equivalem a {fahrenheit:F2}°F");
            }
            else if (opcao == "2")
            {
                double celsius = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"{temperatura}°F equivalem a {celsius:F2}°C");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}
