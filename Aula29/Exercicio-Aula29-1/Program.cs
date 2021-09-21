using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula 29 (Exercício 1) - Criar um programa para ler um número inteiro, e depois dizer se este número é negativo ou não

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero < 0)
            {
                Console.WriteLine($"O número: {numero} é negativo!");
            }
            else
            {
                Console.WriteLine($"O número: {numero} é positivo!");
            }

        }
    }
}
