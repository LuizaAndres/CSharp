using System;

namespace ExDois
{
    class Program
    {
        static public String ExDois(){
            double area, a, b;
            Console.WriteLine("Calculo de area\n");
            Console.WriteLine("Digite o valor da base: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite valor da altura: ");
            b = Convert.ToDouble(Console.ReadLine());
            
                try{
                    area = (a*b);
                    return ($"resultado:{area}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
        }
    }
}