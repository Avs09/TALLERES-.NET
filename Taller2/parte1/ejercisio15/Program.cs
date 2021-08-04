using System;

namespace ejercisio15
{
    class Program
    {
        private static double numero;
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");

            numero = double.Parse(Console.ReadLine());

            cubo();
        }

        public static void cubo()
        {
            if(numero >= 10)
            {
                Console.WriteLine($"El cubo de {numero} es: {Math.Pow(numero, 3)}");
            }
        }
    }
}
