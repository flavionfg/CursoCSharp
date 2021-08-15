using System;
using System.Collections; 
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList{
        public static void Executar() {
            var arraylist = new ArrayList {
                "Palavara",
                3,
                true
            };

            //ArrayList é heterogêneo, pode receber itens de varios tipos. 

            arraylist.Add(3.14);

            foreach(var item in arraylist){
                Console.WriteLine("{0} => {1}", item, item.GetType()); //GetType mostra o tipo do item.

                /*
                Palavara => System.String
                3 => System.Int32
                True => System.Boolean
                3,14 => System.Double
                */
            }
        }
    }
}
