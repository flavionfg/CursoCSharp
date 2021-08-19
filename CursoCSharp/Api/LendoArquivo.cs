using System;
using System.IO;

namespace CursoCSharp.Api
{
    class LendoArquivo
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome(); //Método da outra classe //mesmo pacote.

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path)){
                    sw.WriteLine("Produto;Preco;Qtd");
                    sw.WriteLine("Caneta Bic Preta;3.50;89");
                    sw.WriteLine("Boraccha Branca; 2.89;27");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path)) //Lendo o arquivo e mostrando no console.
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
