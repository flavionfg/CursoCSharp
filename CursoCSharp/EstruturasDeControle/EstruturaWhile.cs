using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar() {
            int palpite = 0;
            Random ramdom = new Random();

            int numeroSecreto = ramdom.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while(tentativasRestantes > 0 && !numeroEncontrado){
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if(numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                  }else if(palpite > numeroSecreto) {
                    Console.WriteLine("Menor...Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0} ", tentativasRestantes);
                }else {
                    Console.WriteLine("Maior...tente novamente!");
                    Console.WriteLine("Tentivas restantes: {0} ", tentativasRestantes);
                }
            }
        }
    }
}
