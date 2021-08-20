using System;
using System.Collections.Generic;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar(){
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists){ //Se não existir é criado.
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos ==================");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos){
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n== Diretórios ===============");
            var pastas = dirInfo.GetDirectories();
            foreach(var pasta in pastas){
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
