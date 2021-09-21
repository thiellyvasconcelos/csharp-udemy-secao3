using System;

namespace Exercicio_Aula24_1
{
    class Program
    {
        // Aula 24 (Exercício 1) - Criar um programa simples de soma de valores informados pelo usuário

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor inteiro: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor inteiro: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine();
            Console.WriteLine($"Soma = {soma}");
        }
    }
}