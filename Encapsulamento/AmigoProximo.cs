using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class AmigoProximo 
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); // Protected
            Console.WriteLine(amiga.NumeroCelular);//Internal
            Console.WriteLine(amiga.JeitoDeFalar); //Internal
            //Console.WriteLine(amiga.SegredoDeFamilia); ///só por herança!
            //Console.WriteLine(amiga.UsuMuitoPhotoshop); ///Protected
        }
    }
}
