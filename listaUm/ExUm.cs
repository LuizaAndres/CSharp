using System;

namespace ExUm
{
    class Program
    {
        static public String ExUm(){
            double media, a, b, c;
            Console.WriteLine("Calculo de mádia\n");
            Console.WriteLine("Digite primeiro valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite ultimo: ");
            c = Convert.ToDouble(Console.ReadLine());
                try{
                    media = ((a+b+c)/3);
                    
                    return ($"resultado:{media}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
        }
    }
}