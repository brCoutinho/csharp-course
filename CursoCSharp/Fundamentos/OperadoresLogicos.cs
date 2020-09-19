using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;//and
            Console.WriteLine($"Comprou a Tv de 50 polegadas? {comprouTv50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;//or
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;//
            Console.WriteLine($"Comprou Tv de 32 polegadas? {comprouTv32}");
            
            Console.WriteLine($"Mais saudável? {!comprouSorvete}"); //negação
        }
    }
}
