using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto{
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y){
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta){
            X += delta; //delta recebe x
            Y += delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar(){
            Coordenada coordenadaInicial; //podemos instanciar desta forma, se utilizarmos class não funcionaria.
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coodernadFinal = new Coordenada(x: 9, y: 1); //Usando parametros nomeados
            coodernadFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0}", coodernadFinal.X);
            Console.WriteLine("Y = {0}", coodernadFinal.Y);
        }
    }
}
