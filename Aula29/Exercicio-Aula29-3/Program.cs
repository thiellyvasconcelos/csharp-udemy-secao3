using System;

namespace Exercicios_Aula_29_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 29 (Exercicio 3) - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São Múltiplos" ou "Não são
               Múltiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
               ordem crescente ou decrescente. */

            int A = 0, B = 0;

            Console.WriteLine("Digite um número inteiro: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro: ");
            B = int.Parse(Console.ReadLine());

            if(A % B == 0 && B % A == 0)
            {
                Console.WriteLine("Os números digitados são múltiplos!");
            }
            else
            {
                Console.WriteLine("Os números digitados NÃO são múltiplos!");
            }
        }
    }
}
