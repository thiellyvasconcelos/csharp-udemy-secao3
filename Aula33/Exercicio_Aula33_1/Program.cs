using System;

namespace Exercicio_Aula33_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
               incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
               impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. */


            int senha;

            Console.WriteLine("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha incorreta, tente novamente!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Senha correta, acesso permitido! :)");
        }
    }
}
