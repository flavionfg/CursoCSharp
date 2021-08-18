using System;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
          //Console.WriteLine(NumeroCelular); Não é acessivel pois não estamos dentro do mesmo projeto.
            Console.WriteLine(JeitoDeFalar);
           //Console.WriteLine(SegredoFamilia);  Não é acessivel pois não estamos dentro do mesmo projeto.
           //Console.WriteLine(UsaMuitoPhotoshop); // Não é acessivel pois é um atributo privado.
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia); 
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); 
        }
    }
    class Encapsulamento
    {
        public static void Executar()
        {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
