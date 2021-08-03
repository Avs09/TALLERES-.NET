using System;

namespace ejercisio7
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese un numero: ");

            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine(getNumeroNegativo(numero));
        }

        public String getNumeroNegativo(double n)
        {
            if(n < 0) return "El numero " + n + " es negativo";

            else return "";
        }   
    }
}
