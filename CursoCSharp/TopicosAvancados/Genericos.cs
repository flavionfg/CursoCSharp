using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>{

        T valorPrivado; //Atributo
        public T Coisa { get; set; } //Propriedade

        public Caixa(T coisa){
            Coisa = coisa;
            valorPrivado = coisa;
        }
        public T metodoGenerico(T valor){
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor(){
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int>{
        public CaixaInt() : base(0){

        }
    }

    //Criando um tipo de objeto de outro pacote
    class CaixaPessoa : Caixa<Pessoa>{
        public CaixaPessoa() : base(new Pessoa()){

        }
    }
    class Genericos{
        public static void Executar(){
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));

            var caixa2 = new Caixa<String>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaPessoa caixa3 = new CaixaPessoa();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
