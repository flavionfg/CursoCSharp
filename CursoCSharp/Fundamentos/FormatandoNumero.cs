using System;
using System.Globalization; //para podermos pegar todas as informaçãoes de moedas

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar(){
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura2));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
