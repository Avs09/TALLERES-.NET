using System;

namespace ejercisio19
{
    class Program
    {
        private String estudiante, programa, ficha, curso;

        private double nota1, nota2, nota3, nota4, nota5;

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            setDatosEstudiante();

            setNotasEstudiante();

            getDatosEstudiante();
        }

        public void setDatosEstudiante()
        {
            Console.Write("Nombre del estudiante: ");

            estudiante = Console.ReadLine();

            Console.Write("Nombre del programa: ");

            programa = Console.ReadLine();

            Console.Write("Numero de ficha: ");

            ficha = Console.ReadLine();

            Console.Write("Nombre del curso: ");

            curso = Console.ReadLine();
        }

        public void setNotasEstudiante()
        {
            Console.Write("Ingrese la primera nota: ");

            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");

            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");

            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cuarta nota: ");

            nota4 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la quinta nota: ");

            nota5 = double.Parse(Console.ReadLine());
        }

        public void getDatosEstudiante()
        {
            Console.WriteLine($"DATOS DEL ESTUDIANTE {estudiante}");

            Console.WriteLine("Curso: " + curso);

            Console.WriteLine("Programa de formacion: " + programa);

            Console.WriteLine("Numero de ficha: " + ficha);

            Console.WriteLine("Promedio de notas: " + (nota1 + nota2 + nota3 + nota4 + nota5) / 5);
        }
    }
}
