using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente{
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia{
        public static void Executar(){
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}"); //3 e 3

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");//4 e 3
            //Os valores são direntes por que é int é um struct e por isso a atribuição é de valor.

            Dependente dep = new Dependente{
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
            //Os valores dos 2 objetos serão identicos, pois a atribuição ocorre por referencia 
        }
    }
}
