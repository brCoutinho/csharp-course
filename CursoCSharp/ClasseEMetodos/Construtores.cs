using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string Modelo, string Fabricante, int Ano)
        {
            this.Modelo = Modelo;
            this.Fabricante = Fabricante;
            this.Ano = Ano;
        }

        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Celta", "GM", 2007);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");
        }
    }
}
