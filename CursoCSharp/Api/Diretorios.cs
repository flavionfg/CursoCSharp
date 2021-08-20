using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar(){
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();
           
            if (Directory.Exists(novoDir)){
                Directory.Delete(novoDir, true); //o true é para excluir de forma recursiva
            }

            if (Directory.Exists(novoDirDestino)){
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir)); //Data e hora da criação do arquivo

            Console.WriteLine("== Pastas =====================");
            var pastas = Directory.GetDirectories(dirProjeto); //Pega as pastas
            foreach(var pasta in pastas){
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos ============");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos){
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Raiz =============");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
