using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //vai inverter o valor, inverte o sinal
            Console.WriteLine(!booleano); //se é falso vira verdadeiro se é verdadeiro vira falso.

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1); //tanto faz se colocar o -- ou ++ antes ou depois da variavel
           
            Console.WriteLine(numero1++ == --numero2); //essa linha de código não favorece uma leitura fluida!
            // quando vc coloca o ++antes da variavel vc esta com mais pressa de incrementar,logo o ++tem precedencia de do que o ++depois da variavel.
            // logo o numero2 será decrementado antes  de ocorrer a comparação com o == e o numero1 só será decrementado depois da comparação.
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
