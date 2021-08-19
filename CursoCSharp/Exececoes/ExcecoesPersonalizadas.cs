using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exececoes
{
    public class NegativoException : Exception {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
        //Uma excessão pode ser usado na hora de construir uma excessão como causa da original.
    }

    public class ImparException : Exception{
        public ImparException(string message) : base(message) { }
    }
    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();

            int valor = random.Next(-30, 30);

            if (valor < 0){
                throw new NegativoException("Número negativo...:(");
            }

            if (valor % 2 == 0){
                throw new ImparException("Número negativo...:(");
            }

            return valor;
        }
        public static void Executar() {
            try {
                Console.WriteLine(PositivoPar());
            } catch(NegativoException ex){
                Console.WriteLine(ex.Message);
            }catch(ImparException ex){
                Console.WriteLine(ex.Message);
            }
        }

    }
}
