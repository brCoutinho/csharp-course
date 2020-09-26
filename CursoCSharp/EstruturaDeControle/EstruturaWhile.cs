using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1,16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            Console.WriteLine("Adivinhe o número sorteado");

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if(numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write($"Número encontrado em {tentativas} tentativa(s).");
                    Console.BackgroundColor = corAnterior; 
                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número sorteado é menor que o número da tentativa" +
                        ", tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                } else
                {
                    Console.WriteLine("O número sorteado é maior que o número da tentativa," +
                        " tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}.");
                }
            }
        }
    }
}
