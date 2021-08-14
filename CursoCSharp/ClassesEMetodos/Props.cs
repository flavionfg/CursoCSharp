using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1; //10% de desconto

        string nome;

        public string Nome {
            get {
                return "Optional: " + nome;
            }
            set{
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoDesconto {
            get => Preco - (desconto * Preco); //Lambda
        }

        public CarroOpcional(){
        }

        public CarroOpcional(string nome, double preco){
            Nome = nome;
            Preco = preco; //podemos usar assim pois estamos usando o get set deles
        }
    }

    class Props
    {
        public static void Executar(){
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direcao elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoDesconto);
        }
    }
}
