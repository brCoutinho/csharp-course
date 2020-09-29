using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "João";
            pessoa.Idade = 24;

            // Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos.");

            pessoa.ApresentarNoConsole();
        }
    }
}
