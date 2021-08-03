using System;

namespace ejercisio22
{
    class Program
    {
        private double balde1L, balde3L, balde5L;
        static void Main(string[] args)
        {
            Program baldes = new Program();

            baldes.calcTiempo();
        }

        public void calcTiempo()
        {
            double tiempo = 90;

            balde1L = (tiempo * 1) / 60;

            balde3L = (tiempo * 3) / 60;

            balde5L = (tiempo * 5) / 60;

            Console.WriteLine("El balde de 1L tardo en llenarse: " + balde1L + " horas(hora y media)");

            Console.WriteLine("El balde de 3L tardo en llenarse: " + balde3L + " horas(cuatro horas y media)");

            Console.WriteLine("El balde de 5L tardo en llenarse: " + balde5L + " horas(Siete horas y media)");
        }
    }
}
