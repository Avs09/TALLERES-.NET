using System;

namespace ejercisio3
{
    class Program
    {
        public static double nota1, nota2, nota3;
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera nota: ");

            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");

            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");

            nota3 = double.Parse(Console.ReadLine());

            definitivaN();
        }

        public static void definitivaN()
        {
            Console.WriteLine("La definitiva de las notas es: " +  (nota1 + nota2 + nota3) / 3);
        }
    }
}
