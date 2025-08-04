using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vinda ao Banco Simples!");
        double saldo = 0;

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Ver saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
                    break;
                case "2":
                    Console.Write("Digite o valor para depositar: R$ ");
                    if (double.TryParse(Console.ReadLine(), out double deposito) && deposito > 0)
                    {
                        saldo += deposito;
                        Console.WriteLine("Depósito realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case "3":
                    Console.Write("Digite o valor para sacar: R$ ");
                    if (double.TryParse(Console.ReadLine(), out double saque) && saque > 0)
                    {
                        if (saque <= saldo)
                        {
                            saldo -= saque;
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Obrigado por usar o Banco Simples. Até logo!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
