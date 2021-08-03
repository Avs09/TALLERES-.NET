using System;

namespace ejercisio13
{
    class Program
    {
        private static double valorH;
        private static int horas;
        static void Main(string[] args)
        {
            String trabajador;

            Console.Write("Trabajador: ");

            trabajador = Console.ReadLine();

            Console.Write("Ingrese las horas: ");

            horas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor por hora: ");

            valorH = double.Parse(Console.ReadLine());

            calcSalario(trabajador);
        }

        public static void calcSalario(String t)
        {
            Console.WriteLine($"{t},tu salario es de: {valorH*horas}$");
        }
    }
}
