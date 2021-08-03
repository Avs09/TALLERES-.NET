using System;

namespace ejercisio14
{
    class Program
    {
        private double num1, num2;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese el numero 1: ");

            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero 2: ");

            num2 = double.Parse(Console.ReadLine());

            suma();
        }
        public void suma()
        {
            String r = num1 > num2 ? "La suma es: " + (num1 + num2) : "";

            Console.WriteLine(r);
        }
    }
}
