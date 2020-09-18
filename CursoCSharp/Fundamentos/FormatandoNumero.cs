using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//Arredonda
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));//Percentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo culturaDolar = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("C2", cultura));
            Console.WriteLine(valor.ToString("C2", culturaDolar));

            int inteiro = 256;

            Console.WriteLine(inteiro.ToString("D10"));//Zeros a esquerda
        }
    }
}
