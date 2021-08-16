using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade{
        public static void Executar() {

            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2; //Atribuição por referencia

            Console.WriteLine(p1 == p2); //False
            Console.WriteLine(p3 == p2); //True

            /*
             * As duas variaveis apontam para locais de memoria diferente, pois cada instancia de produto
             * esta alocado e um outro espaço de memoria, estamos comparando endereço de memoria.
             */

            //Antes de sobrescrever o método
            Console.WriteLine(p1.Equals(p2));//False

            //Depois de sobrescrever o Equals na ColecoesList.cs
            Console.WriteLine(p1.Equals(p2));//True
        }
    }
}
