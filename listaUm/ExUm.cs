using System;

namespace ExUm
{
    class Program
    {
        static public String ExUm(double a, double b, double c ){
                double media;
                try{
                    media = ((a+b+c)/3);
                    
                    return ($"resultado:{media}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
        }
    }
}