using System;
using ExUm;
using ExDois;
using ExTres;
using ExQuatro;
using ExCinco;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( ExUm.Program.ExUm(10, 8, 9) );
            Console.WriteLine( ExDois.Program.ExDois(10, 8) );
            Console.WriteLine( ExTres.Program.ExTres(10, 8, 3) );
            Console.WriteLine( ExQuatro.Program.ExQuatro(10, 8) );
            Console.WriteLine( ExCinco.Program.ExCinco(1, 25, 1) );
        }
    }
}
