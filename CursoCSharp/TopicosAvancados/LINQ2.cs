using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2{
        public static void Executar(){
            var alunos = new List<ALuno>{
                new ALuno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new ALuno() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new ALuno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new ALuno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new ALuno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new ALuno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new ALuno() {Nome = "Marcio", Idade = 18, Nota = 6.8},
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));//Single retorna apenas um resultado!.
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(
                aluno => aluno.Nome.Equals("Fulano"));
            if(fulano == null){
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null){
                Console.Write("Aluno Não encontrado!.");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            //Pula 1 e pega os proximos 3 da lista.
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip){
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine("Maior Nota : " + maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine("Menor Nota : " + menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine("Somatório das notas: " + somatorioNotas);

            var mediaDaTurma = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
