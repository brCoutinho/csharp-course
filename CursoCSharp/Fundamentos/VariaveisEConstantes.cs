using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1412;

            double area = PI * raio * raio;

            Console.WriteLine("A área é: " + area);

            //Tipos Internos

            bool areaGrande = true;

            Console.WriteLine("A área é Grande? " + areaGrande);

            byte idade = 45;

            sbyte saldoDeGols = sbyte.MinValue;//byte com sinal de negativo
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor Inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População " + populacaoBrasileira);

            float precoComputador = 12999.99f;

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Espaço entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'a';
            string texto = "Curso de C#";
                
        }
    }
}
