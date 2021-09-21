using System;
using System.Globalization;

namespace Exercicio_Aula24_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 24 (Exercício 4) - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
               hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.*/

            Console.WriteLine("Digite o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número total de horas trabalhadas: ");
            double Totalhoras = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de pagamento por hora trabalhada: ");
            double PagHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculoPagamento = Totalhoras * PagHora;

            Console.WriteLine($"Número do funcionário: {numero}");
            Console.WriteLine($"Pagamento final: R${calculoPagamento.ToString("F2", CultureInfo.InvariantCulture)}", CultureInfo.InvariantCulture);

        }
    }
}
