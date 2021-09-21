using System;

namespace Exercicio_Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa simples de identificação de números pares ou ímpares

            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0 )
                Console.WriteLine("Número par!");
            else
                Console.WriteLine("Número impar!");
        }
    }
}