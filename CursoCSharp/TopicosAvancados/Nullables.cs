using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables{
        //static int num3; variaveis em nivel de classe são inicializadas por padrão. padrao de int é 0.
        public static void Executar(){
            //Opçao 1
            Nullable<int> num1 = null;

            //Opçao 2
            int? num2 = null;

            if (num1.HasValue){
                Console.WriteLine("Valor de num: {0}", num1);
            }else{
                Console.WriteLine("A variavel não possui valor.");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try{
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);

            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
