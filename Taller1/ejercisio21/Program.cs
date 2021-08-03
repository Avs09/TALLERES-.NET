using System;

namespace ejercisio21
{
    class Program
    {
        private String aprendiz, direccion;
        private int año;
        
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Nombre del aprendiz: ");

            aprendiz = Console.ReadLine();

            Console.Write("Ingrese el año de nacimiento: ");

            año = int.Parse(Console.ReadLine());

            Console.Write("Direccion: ");

            direccion = Console.ReadLine();

            Console.WriteLine("Edad: " + calcEdad());
        }

        public int calcEdad()
        {
            DateTime fechaActual = DateTime.Now;

            int añoActual = fechaActual.Year;

            return añoActual - año;
        }
    }
}
