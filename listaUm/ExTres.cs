using System;

namespace ExTres
{
    class Program
    {
        static public String ExTres(double a, double b, double c){
            double volume;
            try{
                volume = ((a*b)*c);
                return ($"resultado:{volume}");
            }catch(Exception e){
                return ($"Erro{e}");
            }
        }
    }
}