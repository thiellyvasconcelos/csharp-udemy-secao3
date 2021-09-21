using System;
using System.Globalization;

namespace Exercicio_Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 23 (Exercício único) - Crie um programa para guardar os dados informados pelo usuário em variáveis */

            Console.Write("Digite o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a quantidade de quartos de sua residência: ");
            int qnt = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de um produto: ");
            double valorProd = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Entre com o seu último nome, idade e altura (na mesma linha, separando somente por um espaço): ");
            string[] separador = Console.ReadLine().Split(' ');
            
            string name = separador[0];
            int idade = int.Parse(separador[1]);
            double altura = double.Parse(separador[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Imprimindo resultados: ");
            Console.WriteLine($"Nome completo informado: {nome}");
            Console.WriteLine($"Quantidade de quartos informado: {qnt}");
            Console.WriteLine($"Valor do produto informado: {valorProd.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Último sobrenome informado: {name}");
            Console.WriteLine($"Idade informada: {idade}");
            Console.WriteLine($"Altura informada: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
