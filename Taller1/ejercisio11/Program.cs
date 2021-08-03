using System;

namespace ejercisio11
{
    class Program
    {
        private double nota1, nota2, nota3, examen, trabajo;

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Nombre del estudiante: ");

            String estudiante = Console.ReadLine();

            Console.WriteLine("Estudiante " + estudiante + ", tu nota final de algoritmos es: " + calificacionF());
        }

        public double notasP()
        {
            Console.Write("Ingrese la primera nota parcial: ");

            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota parcial: ");

            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota parcial: ");

            nota3 = double.Parse(Console.ReadLine());

            return (nota1 + nota2 + nota3) / 3 * 0.55;
        }

        public double examenF()
        {
            Console.Write("Ingrese la nota del examen final: ");

            examen = double.Parse(Console.ReadLine());

            return examen * 0.3;
        }

        public double trabajoF()
        {
            Console.Write("Ingrese la nota del trabajo final: ");

            trabajo = double.Parse(Console.ReadLine());

            return trabajo * 0.15;
        }

        public double calificacionF()
        {
            return (notasP() + examenF() + trabajoF());
        }
    }
}
