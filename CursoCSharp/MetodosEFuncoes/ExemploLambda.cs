using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda {
        public static void Executar() {

            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random ramdom = new Random();
                return ramdom.Next(1, 7); //vai gerar valores randômicos entre 1 e 7
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //Mesma Funcção sem usar o Lambda:

            //Func<int, string> conversonHex = (numero) =>
            //{
            //    return numero.ToString("X");
            //};

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 2, 2019)); //01/02/2019
        }
    }
}
