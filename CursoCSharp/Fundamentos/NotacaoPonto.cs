﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World.").Replace("World", "Mundo").ToLower();

            Console.WriteLine(saudacao);

            string valorImportante = null;

            Console.WriteLine(valorImportante?.Length);


        }
    }
}
