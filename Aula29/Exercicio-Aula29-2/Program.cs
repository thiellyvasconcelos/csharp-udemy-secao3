using System;

namespace Exercicio_Aula29_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula 29 (Exercicio 2) - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par!");
            }
            else
            {
                Console.WriteLine($"O número: {numero} é ímpar!");
            }
        }
    }
}
