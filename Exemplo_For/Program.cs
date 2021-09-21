using System;

namespace Exemplo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa que irá solicitar um número N e depois N valores inteiros. Irá mostrar a soma dos N valores digitados */

            int soma = 0;
            
            Console.Write("Quantos números inteiros você deseja digitar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int valor = 0;
                Console.WriteLine($"Valor {i}: ");
                valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine("------------");
            Console.WriteLine($"Soma: {soma}");
        }
    }
}
