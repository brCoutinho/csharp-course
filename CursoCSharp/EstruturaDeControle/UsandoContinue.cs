using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine($"Números pares entre 1 e {50}");

            for(int i = 1; i <= intervalo; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }

            //MELHORIA NO CÓDIGO PARA TESTE

            //for(int t = 2; t <= intervalo; t += 2)
            //{
            //    Console.Write(t + " ");
            //}
        }
    }
}
