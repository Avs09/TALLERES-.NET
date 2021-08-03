using System;

namespace ejercisio23
{
    class Program
    {
        private byte distancia;

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese la distancia (metros): ");

            distancia = byte.Parse(Console.ReadLine());

            Console.WriteLine(calcTiempoSubida());
        }

        public String calcTiempoSubida()
        {
            byte altura = 7;

            if(distancia <=7)
            {
                return "Tiempo de subida: " + (distancia * 5) / altura + " horas";
            }
            else return "Error, La altura maxima es de 7m";
        }
    }
}
