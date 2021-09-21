﻿using System;

namespace Exercicio_Aula33_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
                um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
                4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
                que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
                mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
                exemplo*/

            
            Console.WriteLine("Digite um tipo de combustível: ");
            Console.WriteLine(" 1. Álcool\n 2. Gasolina\n 3. Diesel\n 4. Fim do programa");
            int tipoComb = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            int alcool = 0, gasolina = 0, diesel = 0;

            while (tipoComb != 4)
            {
                
                if(tipoComb >= 5 || tipoComb <= 0)
                {
                    Console.WriteLine("Digite um código válido!");
                    Console.WriteLine("----------------------");
                } 
                else if(tipoComb == 1)
                {
                    alcool++;
                }
                else if(tipoComb == 2)
                {
                    gasolina++;
                }
                else if (tipoComb == 3)
                {
                   diesel++;
                }

                Console.WriteLine("Digite um tipo de combustível: ");
                Console.WriteLine(" 1. Álcool \n 2. Gasolina \n 3. Diesel \n 4. Fim do programa");
                tipoComb = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------");
            }
            
            Console.WriteLine("Muito obrigada!");
            Console.WriteLine($"Alcool: {alcool} \n Gasolina: {gasolina} \n Diesel: {diesel}");
        }
    }
}
