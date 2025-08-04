
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vinda ao Jogo de Adivinhação!");

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // número entre 1 e 100
        int tentativas = 0;

        while (true)
        {
            Console.Write("Digite seu palpite (1 a 100) ou 'sair' para encerrar: ");
            string entrada = Console.ReadLine()?.Trim();

            if (entrada.ToLower() == "sair")
            {
                Console.WriteLine("Jogo encerrado. O número era: " + numeroSecreto);
                break;
            }

            int palpite;
            if (!int.TryParse(entrada, out palpite))
            {
                Console.WriteLine("Entrada inválida. Digite um número entre 1 e 100.");
                continue;
            }

            if (palpite < 1 || palpite > 100)
            {
                Console.WriteLine("Número fora do intervalo. Tente um número entre 1 e 100.");
                continue;
            }

            tentativas++;

            if (palpite == numeroSecreto)
            {
                Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
                break;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("Tente um número maior.");
            }
            else
            {
                Console.WriteLine("Tente um número menor.");
            }
        }
    }
}
