using System;
using System.Linq;


namespace ProjetoUniNove
{
    public class Funcoes
    {
        public double Imc(double peso, double altura)
        {  
            return Math.Round(peso / (Math.Pow(altura,2)),6); }
        public string ConvertBool (bool variavel)
        {
            string convertido;
            if (variavel)
                convertido = "1";
            else
                convertido = "0";

            return convertido;

        }
    }
}