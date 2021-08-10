using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo{

        int a = 10;

        public static void Executar() {
            //Acessar variavel 'a' dentro do método Executar!
            //Sem usar This.

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }

        /*
         * O problema é estar dentro de um método statico tentando acessar um atributo de instancia.
         * Para isso precisamos criar uma instancia e atribuir isso a uma variavel antes de printar!
         */

    }
}
