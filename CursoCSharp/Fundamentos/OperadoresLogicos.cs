using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comproTv50 = executouTrabalho1 && executouTrabalho2; 
            Console.WriteLine("Comprou a tv 50? {0}", comproTv50);
            //no {0} vai ocorrer a interpolação, vai aparecer no lugar o true ou false

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorteve? {0}", comprouSorvete);

            var comproTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a tv 35? {0}", comproTv32);
            //^ é um ou exclusivo

            Console.WriteLine("Mais saudavel?? {0}", !comprouSorvete);

        }
    }
}
