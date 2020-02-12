using System;

namespace ExCinco
{
    class Program
    {
        static public String ExCinco(double a, double b, double c){
            double delta;
            delta =(2*b)-(4*a*c);
            Console.WriteLine(delta);
                if(delta>0){
                double raiz = Math.Sqrt(delta);
                double xl = (((-b) + raiz) / 2 * a);
                double xll = (((-b) - raiz) / 2 * a);
                return ($"Os resultados de X é: {xl} e {xll}");
                }
                else{
                    return ("Delta é negativo");
                }
            
        }
    }
}