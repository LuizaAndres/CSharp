using System;

namespace ExSeis
{
    class Program
    {
        static public String ExSeis(double distancia, double tempo){
            double velocidade = distancia / tempo;
            return($"A velocidade média foi de  {velocidade} km/h");            
        }
    }
}