using System;

namespace ejercisio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");

            double numero = double.Parse(Console.ReadLine());

            mayorIgual(numero);
        }

        public static void mayorIgual(double n)
        {
            if(n >= 10)
            {
                Console.WriteLine(n*= 3);
            }
        }
    }
}
