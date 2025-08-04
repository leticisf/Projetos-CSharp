using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vinda ao Jogo de Adivinhação!");

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Número entre 1 e 100
        int tentativasMax = 6;
        int tentativas = 0;
        bool acertou = false;

        while (tentativas < tentativasMax && !acertou)
        {
            Console.Write($"Tentativa {tentativas + 1} de {tentativasMax}. Digite seu palpite: ");
            string entrada = Console.ReadLine();
            int palpite;

            if (!int.TryParse(entrada, out palpite))
            {
                Console.WriteLine("Por favor, digite um número válido.");
                continue;
            }

            tentativas++;

            if (palpite == numeroSecreto)
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas!");
                acertou = true;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else
            {
                Console.WriteLine("O número secreto é menor.");
            }
        }

        if (!acertou)
        {
            Console.WriteLine($"Suas tentativas acabaram! O número era {numeroSecreto}.");
        }
    }
}
