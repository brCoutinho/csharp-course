using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(3, 7);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(6,18));
            Console.WriteLine(calculadoraComum.Multiplicar(7,7));

        }
    }
}
