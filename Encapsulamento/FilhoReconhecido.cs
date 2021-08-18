using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");

            Console.WriteLine(InfoPublica); //é atributo publico, logo poderemos acessar!
            Console.WriteLine(CorDoOlho); //é um atributo protected, vamos receber pois estamos herdando SubCelebridade.
            Console.WriteLine(NumeroCelular);// internal - consigo acessar pois estou no mesmo projeto.
            Console.WriteLine(JeitoDeFalar);//passado por herança ou mesmo projeto.
            Console.WriteLine(SegredoFamilia);//trasnmitido por herança mas precisa estar no mesmo projeto.
            //Console.WriteLine(UsaMuitoPhotoshop); // não vai funcionar pois é um atributo privado.
        }
    }
}
