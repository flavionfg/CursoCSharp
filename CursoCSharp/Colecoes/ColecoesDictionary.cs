using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary{
        public static void Executar(){
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gradiador");
            filmes.Add(2002, "Homen-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            /*
               - Chave do tipo inteiro e o valor do tipo String.
               - Na parte do valor aceita repetição e na chave não.
               - A chave não precisa ser necessariamente um inteiro.
             */

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004)); 
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia")); //False

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");
            //O método Remove() retira o elemento e retorna um boooleano falando se encontrou a chave e se deletou ou não.

            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            //Percorrendo por chave
            foreach (int chave in filmes.Keys){
                Console.WriteLine(chave);
            }

            //Percorrendo por valor
            foreach(var valor in filmes.Values){
                Console.WriteLine(valor);
            }

            //Percorrendo por chave e valor
            foreach (KeyValuePair<int, string> filme in filmes){
                Console.WriteLine($"{filme.Value} è de {filme.Key}");
            }

            //Simplificando
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} è de {filme.Key}");
            }
        }
    }
}
