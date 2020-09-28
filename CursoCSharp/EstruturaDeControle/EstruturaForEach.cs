using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Problemático";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new String[]
            {"Amanda","Thiago","Lucas","Jairo","Hernanes"};

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
