using System;

namespace ejercisio11
{
    class Program
    {
        private double nota1, nota2, nota3, nota4;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese la primera nota: ");

            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");

            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");

            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cuarta nota: ");

            nota4 = double.Parse(Console.ReadLine());

            Console.WriteLine(calcPromedio());
        }

        public String calcPromedio()
        {
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            return promedio < 3.5 ? $"Lo siento, has reprobado la materia en: {promedio}" : "";
        }
    }
}
