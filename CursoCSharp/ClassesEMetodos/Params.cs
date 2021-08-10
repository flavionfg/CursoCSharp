using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params{

        /*
         * params é uma palavra reservada do C# permite passar parametros variaveis.
         * no nosso caso estamos passando um Array de strings.
         */

        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar(){
            Recepcionar("Flavio", "Leandro", "Celso", "Gabriel", "Rafael", "Marcos", "Eduardo");
        }
   }
}
