using System;

namespace ejercisio2
{
    class Program
    {
        private double numero1, numero2;

        static void Main(string[] args)
        {
            Program operaciones = new Program();

            Console.WriteLine("La suma es: " + operaciones.suma());

            Console.WriteLine("La resta es: " + operaciones.resta());

            Console.WriteLine("La multiplicacion es: " + operaciones.multiplicacion());

            Console.WriteLine("La division es: " + operaciones.division());
        }

        public Program()
        {
            Console.Write("Ingrese el primer numero: ");

            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");

            numero2 = double.Parse(Console.ReadLine());
        }

        public double suma() => numero1 + numero2;

        public double resta() => numero1 - numero2;

        public double multiplicacion() => numero1 * numero2;

        public double division() => numero1 / numero2;
    }
}
