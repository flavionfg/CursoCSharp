using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class AtributosEstaticos
    {

        public class Produto{
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            /*Quando colocamos static no atributo ele só torna um atributo de classe e não de instancia.
            Neste caso só teria uma copia de desconto para todos os produtos instanciados, tendo em vista
            que todas as instancias de Produto iram usar o seu valor.
            */
            
            public Produto(string nome, double preco, double desconto) {
                Nome = nome;
                Preco = preco;
                Desconto = desconto; //como não tem não temos o this aqui estes atributos são especificados para cada objeto instanciado.
            }

            public Produto() {

            }

            public double CalcularDesconto() {
                return Preco - Preco * Desconto;
            }
        }
        public static void Executar() {

            var produto1 = new Produto("Caneta", 3.2, 0.1); //desconto de 10%

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
