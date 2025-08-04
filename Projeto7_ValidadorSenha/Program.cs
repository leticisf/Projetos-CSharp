using System;
using System.Text.RegularExpressions; // Biblioteca para trabalhar com expressões regulares

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vinda ao Validador de Senha!");

        while (true)
        {
            Console.Write("Digite uma senha para validar (ou 'sair' para encerrar): ");
            string senha = Console.ReadLine();

            if (senha.ToLower() == "sair")
            {
                Console.WriteLine("Encerrando o validador...");
                break;
            }

            // Verifica se a senha tem pelo menos 8 caracteres
            bool temOitoOuMais = senha.Length >= 8;

            // Verifica se contém letra maiúscula
            bool temMaiuscula = Regex.IsMatch(senha, @"[A-Z]");

            // Verifica se contém letra minúscula
            bool temMinuscula = Regex.IsMatch(senha, @"[a-z]");

            // Verifica se contém número
            bool temNumero = Regex.IsMatch(senha, @"\d");

            // Verifica se contém caractere especial
            bool temEspecial = Regex.IsMatch(senha, @"[\W_]");

            if (temOitoOuMais && temMaiuscula && temMinuscula && temNumero && temEspecial)
            {
                Console.WriteLine("Senha forte!");
            }
            else
            {
                Console.WriteLine("Senha fraca. Ela deve ter pelo menos 8 caracteres, " +
                    "letras maiúsculas, minúsculas, números e caracteres especiais.");
            }
        }
    }
}
