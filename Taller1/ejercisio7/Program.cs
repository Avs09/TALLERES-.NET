using System;

namespace ejercisio7
{
    class Program
    {
        private int horas, minutos, segundos;
        static void Main(string[] args)
        {
            Program tiempo = new Program();

            Console.WriteLine($"{tiempo.horas}:{tiempo.minutos}:{tiempo.segundos}, equivalen a: {tiempo.equivalenciaS()} segundos");
        }

        public Program()
        {
            Console.Write("Ingrese la hora: ");

            horas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los minutos: ");

            minutos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los segundos: ");

            segundos = int.Parse(Console.ReadLine());
        }

        public double equivalenciaS()
        {
            double equivalencia = (horas * 3600) + (minutos * 60) + segundos;

            return equivalencia;
        }
    }
}
