using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class CoelecoesStack{
        public static void Executar(){
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha){
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");
            //Pop() ele remove o ultimo elemento adicionado da lista e retorna ele.

            foreach (var item in pilha){
                Console.WriteLine($"{item}");
            }

            //Peek() vai pegar o ultimo elemento adicionado, mas não vai remover.
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count); //3 elementos 
        }
    }
}
