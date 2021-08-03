using System;

namespace ejercisio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;

            Console.Write("Ingrese el primer numero: ");

            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");

            numero2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");

            numero3 = double.Parse(Console.ReadLine());
            
            suma(numero1, numero2, numero3);
        }

        public static void suma(double n1, double n2, double n3)
        {
            Console.WriteLine("La suma es: " + (n1 + n2 + n3));
        }
    }
}
