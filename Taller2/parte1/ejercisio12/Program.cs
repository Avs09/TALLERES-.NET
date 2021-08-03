using System;

namespace ejercisio12
{
    class Program
    {
        private static double altura;
        private static String estudiante;
        static void Main(string[] args)
        {
            Console.Write("Nombre del estudiante: ");

            estudiante = Console.ReadLine();

            Console.Write("Ingrese la estatura: ");

            altura = double.Parse(Console.ReadLine());

            Console.WriteLine(calcEstatura());
        }

        public static String calcEstatura()
        {
            return altura > 1.70 ? $"{estudiante}, eres alt@" : "";
        }
    }
}
