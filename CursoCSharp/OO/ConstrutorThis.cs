using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome) //o This esta chamando o construtor base para setar o nome.
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!"; //Sem este método na hora de printar a classe vai aparecer o caminho dela e não o valor.
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var caramelo = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(caramelo);
            //Console.WriteLine(caramelo.ToString());
        }
    }
}
