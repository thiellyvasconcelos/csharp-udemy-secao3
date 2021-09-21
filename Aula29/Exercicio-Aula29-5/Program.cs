using System;
using System.Globalization;

namespace Exercicio_Aula29_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 29 (Exercício 5) - Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
               A seguir, calcule e mostre o valor da conta a pagar.
            
                CODIGO          ESPECIFICAÇÃO          PREÇO
                1               Cachorro quente        R$ 4.00
                2               X-Salada               R$ 4.50
                3               X-Bacon                R$ 5.00
                4               Torrada Simples        R$ 2.00
                5               Refrigerante           R$ 1.50
             
             */

            Console.WriteLine("Código do item - Quantidade (mesma linha, separado apenas por espaço) -");
            string[] entradas = Console.ReadLine().Split(' ');
            int codigo = int.Parse(entradas[0]);
            int qnt = int.Parse(entradas[1]);

            double total = 0.0;
            double precoUnitario;

            if(codigo == 1)
            {
                precoUnitario = 4.00;
                total =  qnt * precoUnitario;
                
            }
            else if(codigo == 2)
            {
                precoUnitario = 4.50;
                total = qnt * precoUnitario;
            }
            else if(codigo == 3)
            {
                precoUnitario = 5.00;
                total = qnt * precoUnitario;
            }
            else if(codigo == 4)
            {
                precoUnitario = 2.00;
                total = qnt * precoUnitario;
            }
            else if(codigo == 5)
            {
                precoUnitario = 1.50;
                total = qnt * precoUnitario;
            }
            else
            {
                Console.WriteLine("Código inválido!");
                
            }

            Console.WriteLine($"Preço total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
