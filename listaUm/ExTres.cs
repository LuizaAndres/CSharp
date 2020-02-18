using System;

namespace ExTres
{
    class Program
    {
        static public String ExTres(){
            double volume,a, b, c;
            Console.WriteLine("Calculo de volume\n");
            Console.WriteLine("Digite valor pra base: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite valor pra alutra: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite valor pra profundidade: ");
            c = Convert.ToDouble(Console.ReadLine());
            try{
                volume = ((a*b)*c);
                return ($"resultado:{volume}");
            }catch(Exception e){
                return ($"Erro{e}");
            }
        }
    }
}