using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double FATOR = 5.0/9.0;
        double AJUSTE = 32;

        double fahrenheit = 86;
        double celsius = (fahrenheit - AJUSTE) * FATOR;

        Console.WriteLine("O valor de "+ fahrenheit +" fahrenheit em Celsius é " + celsius + "°C.");
        
        fahrenheit = 150;
        celsius = (fahrenheit - AJUSTE) * FATOR;
        Console.WriteLine("O valor de "+ fahrenheit +" fahrenheit em Celsius é " + celsius + "°C.");
        
        }
    }
}
