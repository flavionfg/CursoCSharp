using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //Heranca
        protected string CorDoOlho = "Verde";

        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 551199999999;

        //Heranca ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        //mesma class ou heranca no mesmo projeto (só funciona na versão do c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão 
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
