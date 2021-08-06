using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica { 
        public static int Somar(int a, int b) {
            return a + b;
        }
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class MetodosEstaticos{
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);
            Console.WriteLine(CalculadoraEstatica.Somar(2, 2));

            //Método estatico eu posso acessar sem criar uma instancia.
            //O método pertence a classe e não a um objeto.
            //Quando o método tem static ele é acessivel através da classe, ja o que não tem
            //pode ser acessado via objeto de instancia.
        }
    }
}

