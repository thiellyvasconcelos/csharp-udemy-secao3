using System;
using System.Globalization;

namespace Exercicio_Aula24_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 24 (Exercício 6) - Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
                  
                  a) a área do triângulo retângulo que tem A por base e C por altura.
                  b) a área do círculo de raio C. (pi = 3.14159)
                  c) a área do trapézio que tem A e B por bases e C por altura.
                  d) a área do quadrado que tem lado B.
                  e) a área do retângulo que tem lados A e B. */

            Console.WriteLine("Digite o valor 1: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor 2: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor 3: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTrianguloR = (A * C) / 2;
            double PI = 3.14159;
            double areaCirculo = PI * (C * C);
            double areaTrapezio = ((A + B) / 2) * C;
            double areaQuadrado = B * B;
            double areaRetangulo = A * B;

            Console.WriteLine($"A área do triângulo retângulo que tem A por base e C por altura: {areaTrianguloR.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A área do círculo de raio C: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A área do trapézio que tem A e B por bases e C por altura: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A área do quadrado que tem lado B: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A área do retângulo que tem lados A e B : {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
