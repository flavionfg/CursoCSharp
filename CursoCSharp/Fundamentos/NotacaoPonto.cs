using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            //String valorImporte = null;
            //Console.WriteLine(valorImporte.Length); ///vai dar erro Ocorreu um erro: Object reference not set to an instance of an object.

            String valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //com o ? ele nao da erro na tela!
        }
    }
}
