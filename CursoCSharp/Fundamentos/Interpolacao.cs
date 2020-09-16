using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Aspire 5";
            string marca = "Acer";
            double valor = 3799.00;

            Console.WriteLine("O {0} da marca {1} custa {2}.",nome,marca,valor);

            Console.WriteLine($"A marca {marca} é legal");
            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}
