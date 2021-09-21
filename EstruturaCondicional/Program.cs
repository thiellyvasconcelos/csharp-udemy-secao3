using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            // Programa simples que irá retornar a mensagem para o usuário de acordo com o horário informado pelo mesmo 

            Console.WriteLine("Digite a hora atual: ");
            int horario = int.Parse(Console.ReadLine());

            if(horario < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(horario < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}