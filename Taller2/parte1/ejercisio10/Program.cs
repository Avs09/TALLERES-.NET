using System;

namespace ejercisio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la edad: ");

            byte edad = byte.Parse(Console.ReadLine());

            Console.WriteLine(getEdad(edad));
        }

        public static String getEdad(byte e) => e >= 18 ? "Eres mayor de edad" : "";
    }
}
