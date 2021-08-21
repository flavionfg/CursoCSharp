using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class ALuno{
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
    {
        public static void Executar() {
            var alunos = new List<ALuno>{
                new ALuno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new ALuno() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new ALuno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new ALuno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new ALuno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new ALuno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new ALuno() {Nome = "Marcio", Idade = 18, Nota = 6.8},
            };

            Console.WriteLine("== Aprovados =============");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach(var aluno in aprovados){
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("== Chamada =============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach(var aluno in chamada){
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por Idade) =============");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados){
                Console.WriteLine(aluno);
            }
        }
    }
}
