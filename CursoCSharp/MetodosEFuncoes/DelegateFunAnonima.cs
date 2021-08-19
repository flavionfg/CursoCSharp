using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateFunAnonima
    {
        delegate string StringOPeracao(string s);
        public static void Executar()
        {
            //vai inverter os caracters de uma string
            StringOPeracao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();//Convertendo a string em uma cadeia/Array de Caracteres 
                Array.Reverse(charArray); //inverte os Caracteres 
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!!"));
        }
    }
}
