using System;

namespace ejercisio12
{
    class Program
    {
        private int cantidadM, cantidadF;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese la cantidad de estudiantes masculinos: ");

            cantidadM = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de estudiantes femeninos: ");

            cantidadF = int.Parse(Console.ReadLine());

            estudiantesPorc();
        }

        public void estudiantesPorc()
        {
            double totalEstudiantes = cantidadF + cantidadM;

            Console.WriteLine("Porcentaje de estudiantes femeninos: " + Math.Round((cantidadF / totalEstudiantes) * 100) + "%");

            Console.WriteLine("Porcentaje de estudiantes masculinos: " + Math.Round((cantidadM / totalEstudiantes) * 100) + "%");

            Console.WriteLine("Cantidad de estudiantes: " + totalEstudiantes);
        }
    }
}
