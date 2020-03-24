using System;
using ExUm;
using ExDois;
using ExTres;
using ExQuatro;
using ExCinco;
using ExSeis;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Crie um programa que calcule a média)");
            Console.WriteLine("2 - Crie um programa que calcule a área");
            Console.WriteLine("3 - Crie um programa que calcule o volume");
            Console.WriteLine("4 - Crie um programa que avalie se um valor é maior do que o dobro de outro valor");
            Console.WriteLine("5 - Crie um programa que calcule bhaskara");
            Console.WriteLine("6 - Crie um programa que calcule a velocidade média de uma viagem");
            Console.WriteLine("7 - Crie um programa que calcule o percentual de imposto pago (faturamento/qtd imposto)");
            Console.WriteLine("8 - Crie um programa que teste se um valor é par ou ímpar");
            Console.WriteLine("9 - Crie um programa que avalie se um valor é maior do que o dobro de outro valor");
            Console.WriteLine("10 - Crie um programa que compare dois valores Strings ");
            Console.WriteLine("11 - Crie um programa que tenha uma variável com ponto em String e converta seu valor para inteiro");
            Console.WriteLine("12 - Crie um programa que tenha uma variável com ponto em String e converta seu valor para inteiro");

            Console.WriteLine( ExUm.Program.ExUm(10, 8, 9) );
            Console.WriteLine( ExDois.Program.ExDois(10, 8) );
            Console.WriteLine( ExTres.Program.ExTres(10, 8, 3) );
            Console.WriteLine( ExQuatro.Program.ExQuatro(10, 8) );
            Console.WriteLine( ExCinco.Program.ExCinco(1, 25, 1) );
            Console.WriteLine( ExSeis.Program.ExSeis(100, 100) );
        }
    }
}
