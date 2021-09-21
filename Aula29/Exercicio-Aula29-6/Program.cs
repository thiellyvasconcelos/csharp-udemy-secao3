using System;
using System.Globalization;
namespace Exercicio_Aula29_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 29 (Exercício 6) - Criar um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
               seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
               nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.  */

            Console.WriteLine("Digite um valor qualquer: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0 || valor > 100.0)
            {
                Console.WriteLine("Fora do intervalo!");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("Intervalo: [0.25]");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intervalo: [25.50]");
            }
            else if (valor <= 75.0)
            {
                Console.WriteLine("Intervalo: [50.75]");
            }
            else
            {
                Console.WriteLine("Intervalo: [75.100]");
            }
        }
    }
}
