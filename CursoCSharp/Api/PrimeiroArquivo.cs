using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString{
        public static string ParseHome(this string path){
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
            //Verifica se a variavel de ambiente é linux,mac ou windows e altera o ~ pela variavel Home.
        }
    }
    class PrimeiroArquivo
    {
       public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)){
              using(StreamWriter sw = File.CreateText(path)){ //Cria um arquivo
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                    Console.WriteLine($"Arquivo {sw} foi criado em {path} .");
                }
            }

            using (StreamWriter sw = File.AppendText(path)){ //Altera um arquivo
                    sw.WriteLine(" ");
                    sw.WriteLine("É possivel");
                    sw.WriteLine("Adicionar");
                    sw.WriteLine("mais texto!");
                    Console.WriteLine($"Arquivo {sw} foi alterado em {path} .");
            }
        }
    }
}
