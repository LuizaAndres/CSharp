using System;

namespace ExQuatro
{
    class Program
    {
        static public String ExQuatro(double a, double b){
            double dobro = a * 2;
            if (dobro > b) {
                return("dobro de a é maior que b");
            }
            else{
                return("dobro de a é menor que b");
            }
            
        }
    }
}