using System;

namespace Exercicio_Aula29_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Aula 29 (Exercício 4) - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
               começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

            string[] vt = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vt[0]);
            int horaFinal = int.Parse(vt[1]);

            int duracao;
            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O jogo durou {duracao} hora(s)");
        }
    }
}
