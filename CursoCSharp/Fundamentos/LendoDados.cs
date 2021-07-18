using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() {
            {
                Console.WriteLine("Qual é o seu nome? ");
                String nome = Console.ReadLine(); //ler dados do console

                Console.WriteLine("Qual é a sua idade?");
                int idade = int.Parse(Console.ReadLine());//a priori ele le uma string, mas estamos convertendo pra int

                Console.WriteLine("Qual é o seu salario ? ");
                double salario = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);

                Console.WriteLine($" {nome} {idade} R${salario}");

            }
        }
    }
}
