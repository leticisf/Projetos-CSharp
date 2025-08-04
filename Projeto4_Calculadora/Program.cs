using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vinda à Calculadora Básica!");

        while (true)
        {
            // Pede o primeiro número
            Console.Write("Digite o primeiro número: ");
            string entrada1 = Console.ReadLine()?.Trim();
            double num1;

            if (!double.TryParse(entrada1, out num1))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                continue;
            }

            // Pede o segundo número
            Console.Write("Digite o segundo número: ");
            string entrada2 = Console.ReadLine()?.Trim();
            double num2;

            if (!double.TryParse(entrada2, out num2))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                continue;
            }

            // Pede a operação
            Console.Write("Digite a operação (+, -, *, /) ou 'sair' para encerrar: ");
            string operacao = Console.ReadLine()?.Trim();

            if (operacao.ToLower() == "sair")
            {
                Console.WriteLine("Saindo da calculadora...");
                break;
            }

            double resultado;

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: divisão por zero não é permitida.");
                        continue;
                    }
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operação inválida. Tente novamente.");
                    continue;
            }

            Console.WriteLine($"Resultado: {resultado}\n");
        }
    }
}
