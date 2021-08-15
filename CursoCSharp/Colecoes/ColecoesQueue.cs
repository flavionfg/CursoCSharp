using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue{
        public static void Executar(){
            var fila = new Queue<string>();

            fila.Enqueue("Fulano"); //Adicona na fila
            fila.Enqueue("Sicrano"); 
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());//Peek() pega o primeiro da fila
            Console.WriteLine(fila.Count);//no Array para contar os elementos usamos o .Lenght, nas coleçõe usamos o .Count.

            Console.WriteLine(fila.Dequeue()); //Dequeue() retira o primeiro elemento da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoas in fila){
                Console.WriteLine(pessoas);
            }

            var salada = new Queue(); //para usarmos este precisamos do import using System.Collections;
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); //False pois nao temos item com i minusculo na lista 
            Console.WriteLine(salada.Contains("Item")); //True

            //Aceita itens Repetidos
        }
    }
}
