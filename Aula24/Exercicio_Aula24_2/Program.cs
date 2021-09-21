using System;
using System.Globalization;

namespace Exercicio_Aula24_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Aula 24 (Exercício 2) -Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
               casas decimais conforme exemplos. Fórmula da área: area = π . raio2
               
               Considere o valor de π = 3.14159 */


            Console.WriteLine("Digite o raio de um círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorPi = 3.14159;
            double area = valorPi * (raio * raio);

            Console.WriteLine($"O valor da área do círculo é: {area.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}