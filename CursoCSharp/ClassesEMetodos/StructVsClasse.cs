using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct Sponto{ //Struct
        public int X;
        public int Y; 
    }

    public class Cponto{ //Classe
        public int X;
        public int Y;
    }
    class StructVsClasse
    {
        public static void Executar(){
            Sponto ponto1 = new Sponto { X = 1, Y = 3 }; //No Struct a atribuição é sempre feita por valor e não por referencia. 
            Sponto copiaPonto1 = ponto1; //Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X); //3
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X); //1  valor original na construção do objeto.
            //Não apontam para o mesmo local de memoria

            Cponto ponto2 = new Cponto { X = 2, Y = 4 };
            Cponto copiaPonto2 = ponto2;//Atribuição por REFERENCIA!!!
            ponto2.X = 4;
            Console.WriteLine("Ponto 2 X:{0}", ponto2.X); //4
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X); //4
            //Apontam para o mesmo local de memoria, por isso ambos estao com o valor 4 no atributo X

            /*
            Ponto 1 X: 3
            Copia Ponto 1 X: 1
            Ponto 2 X: 4
            Copia Ponto 2 X: 4
            */
        }
    }
}
