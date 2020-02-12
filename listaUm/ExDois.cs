using System;

namespace ExDois
{
    class Program
    {
        static public String ExDois(double a, double b){
                double area;
                try{
                    area = (a*b);
                    return ($"resultado:{area}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
        }
    }
}