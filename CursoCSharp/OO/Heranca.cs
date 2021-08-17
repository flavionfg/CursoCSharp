using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidamaxima){
            VelocidadeMaxima = velocidamaxima;
        }

        protected int AlterarVelocidade(int delta){

            int novaVelocidade = VelocidadeAtual + delta;

            if(novaVelocidade < 0) {
                VelocidadeAtual = 0;
            }else if(novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = novaVelocidade;
            }else{
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() { //Virtual é necessario para que o método possa ser sobreescrito
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }

        }
        public class Uno : Carro{
            public Uno() : base(200){  //se tivesse o construtor padrão explicito(digitado na classe) não iria precisar usar o : base.
            }
        }

        public class Ferrari : Carro {
            public Ferrari() : base(350) {
            }

            public override int Acelerar() {
                  return AlterarVelocidade(+15);
            }

            public new int Frear(){ //use o new para sobreescrever método ocultando o da classe pai.
                 return AlterarVelocidade(-15);
            }
        }

        class Heranca{
        public static void Executar(){
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro");
            Carro carro3 = new Ferrari(); 
            Console.WriteLine(carro3.Acelerar()); //Esta chamando o método Frear que esta dentro de Carro e não Ferrari.
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro");
            carro3 = new Uno(); //Polimorfismo , carro3 esta assumindo a forma de UNO.
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
