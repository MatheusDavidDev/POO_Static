using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar e ? // Conversor c = new Conversor();
            // Chamamos nossa classe estatica, sem precisar instanciar
            Console.WriteLine( Conversor.DolarParaReal(4f) );

            Console.WriteLine( Conversor.RealParaDolar(50f) );
            
            // Exemplo: Classe Math
            Console.WriteLine( Math.Pow(2 , 4) );

            Console.WriteLine( Conversor.EuroParaReal(10F) );

            Console.WriteLine( Conversor.RealParaEuro(100f) );

        
        }
    }
}
