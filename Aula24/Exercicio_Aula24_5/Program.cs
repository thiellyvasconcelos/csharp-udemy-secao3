using System;
using System.Globalization;

namespace Exercicio_Aula24_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 24 (Exercício 5) - Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
               o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.  */

            Console.WriteLine("Digite (na mesma linha) - Código Peça 1, Número de peças, Valor unitário Peça 1 ");
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int NPecas1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite (na mesma linha) - Código Peça 2, Número de peças, Valor unitário Peça 2 ");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);
            int NPecas2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double calculoFinal = (NPecas1 * valor1) + (NPecas2 * valor2);

            Console.WriteLine();
            Console.WriteLine($"Valor final a ser pago: {calculoFinal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
