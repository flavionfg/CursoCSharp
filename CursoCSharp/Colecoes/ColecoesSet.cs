using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet{

        /*
         HashSet não é uma estrutura indexada, logo não podemos chamar por indice ou usar a o RemoveAt(index) que usamos no exemplo do ArrayList, ou o IndexOf.

         Set não aceita repetição.

         no lugar do AddRange é UnionWith.

         */

        public static void Executar() {
            var livro = new Produto("Game of throne", 49.9);
            var carinho = new HashSet<Produto>();
            carinho.Add(livro);

            var combo = new HashSet<Produto>{ //List também funcionaria
                new Produto(" Camisa", 29.9),
                new Produto(" 8º Temporada Game Of Thrones", 99.9),
                new Produto(" Poster", 10)
               
            };

            carinho.UnionWith(combo); 
            Console.WriteLine(carinho.Count); 
            //carinho.RemoveAt(3); 

            foreach(var item in carinho){
                //Console.Write(carinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carinho.Count); 
            carinho.Add(livro);
            Console.WriteLine(carinho.Count); 
            //Console.WriteLine(carinho.LastIndexOf(livro)); 

            //Neste caso mesmo se adicionarmos o mesmo livro ele não conta.
        }
    }
}
