using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    /// <summary>
    /// Classe que representa uma Pessoa
    /// </summary>
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole(){
            Console.WriteLine(Apresentar());
        }

        public void Zerar(){
            Nome = "";
            Idade = 0;
        }
    }
    //.Format() funciona como um WriteLine, mas em vez de imprimir no console
    //ele retorna uma string formatada.
}
