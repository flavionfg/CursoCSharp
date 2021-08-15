using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPadrao{

        public static int Somar(int a = 1, int b = 1) //Passando parâmetro com valor padrão
        {
            return a + b;
        }
        
        public static void Executar(){

            Console.WriteLine(Somar(10, 23)); //33 
            Console.WriteLine(Somar(50)); //51 pois como passamos apenas um Argumento ele vai entender que é valor para o Parâmetro a
            Console.WriteLine(Somar()); //2 pois como não foi passado Argumentos ele considera os valores padrãos 
            Console.WriteLine(Somar(b: 7)); //8 passamos parametro nomeados apenas para o argumento b
        }
    }
}
