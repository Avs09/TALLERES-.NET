using System;

namespace ejercisio4
{
    class Program
    {
        private double nota1, nota2, nota3;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese la nota 1: ");

            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");

            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 3: ");

            nota3 = double.Parse(Console.ReadLine());

            calcDef();
        }

        public void calcDef()
        {
            nota1 = nota1 * 0.2;

            nota2 = nota2 * 0.3;

            nota3 = nota3 * 0.5;

            Console.WriteLine("La definitiva es: " + (nota1 + nota2 + nota3));
        }
    }
}
