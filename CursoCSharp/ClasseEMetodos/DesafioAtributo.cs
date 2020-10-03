using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            var desafio = new DesafioAtributo();

            Console.WriteLine($"Consegui pegar o valor de 'a' que é: {desafio.a}.");
        }
    }
}
