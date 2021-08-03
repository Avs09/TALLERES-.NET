using System;

namespace ejercisio4
{
    class Program
    {
        private double numero1, numero2;

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese el numero 1: ");

            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero 2: ");

            numero2 = double.Parse(Console.ReadLine());

            suma();
        }

        public void suma()
        {
            if(numero1 > numero2)
            {
                Console.WriteLine("La suma es: " + (numero1 + numero2));
            }
        }
    }
}
