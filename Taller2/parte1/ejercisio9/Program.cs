using System;

namespace ejercisio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");

            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine(multiploDeCinco(numero));
        }

        public static String multiploDeCinco(double n)
        {
            if(n %5 == 0) return $"El {n} es multiplo de 5";
            
            else return "";
        }
    }
}
