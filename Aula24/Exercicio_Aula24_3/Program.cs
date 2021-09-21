using System;

namespace Exercicio_Aula24_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 24 (Exercício 3) - Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
               de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            Console.WriteLine("Digite o primeiro valor inteiro: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor inteiro: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor inteiro: ");
            int valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor: ");
            int valor4 = int.Parse(Console.ReadLine());

            int produto = (valor1 * valor2 - valor3 * valor4);

            Console.WriteLine($"Diferença: {produto}");
        
        }
    }
}
