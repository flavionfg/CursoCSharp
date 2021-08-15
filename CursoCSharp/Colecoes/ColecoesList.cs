using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
       public string Nome;
       public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class ColecoesList{
        public static void Executar() {
            var livro = new Produto("Game of throne", 49.9);
            var carinho = new List<Produto>();
            carinho.Add(livro);

            var combo = new List<Produto>{
                new Produto(" Camisa", 29.9),
                new Produto(" 8º Temporada Game Of Thrones", 99.9),
                new Produto(" Poster", 10)
                // é possivel colocar quantos elementos quiser na lista, ela é dinamica.
            };

            carinho.AddRange(combo); //adiciona varios elementos de uma unica vez.
            Console.WriteLine(carinho.Count); //conta a quantidade de elementos contidos na lista.
            carinho.RemoveAt(3); //remove um elemento por indice.

            foreach(var item in carinho){
                Console.Write(carinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carinho.Count); //3
            carinho.Add(livro);
            Console.WriteLine(carinho.Count); //4
            // a lista aceita itens repetidos
            Console.WriteLine(carinho.LastIndexOf(livro)); 
        }
    }
}
