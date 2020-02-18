using System;

namespace ExQuatro
{
    class Program
    {
        static public String ExQuatro(){
            double dobro, a, b;
            
            Console.WriteLine("Calculo de dobro\n");
            Console.WriteLine("Digite valor de 'a': ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite valor de 'b': ");
            b = Convert.ToDouble(Console.ReadLine());
            dobro = a*2;
            if (dobro > b) {
                return("dobro de a é maior que b");
            }
            else{
                return("dobro de a é menor que b");
            }
            
        }
    }
}