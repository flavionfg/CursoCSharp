using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            // area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos:

            bool estaChovendo = true;
            Console.WriteLine("Estra chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue; //Mais usados dos inteiros!
            Console.WriteLine("Menor int" + menorValorInt);

            uint populacaoBrasileira = 207_600_000; //byte sem sinal
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            ulong populacaoMundical = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundical);

            float precoComputador = 1299.99f; //Para ser float tem que ter o f no final, se nao vira um double

            double valorDeMercadoDaApple = 1_000_000_000_0000.00; //Mais usado

            decimal distanciaEntreEstrelas = decimal.MaxValue;

            char letra = 'b'; //Apenas uma letra

            string texto = "Seja bem vindo ao curso";

        }
    }
}
