using System;

namespace ejercisio5
{
    class Program
    {
        private double distancia;
        private int tiempo;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese la distancia [km]: ");

            distancia = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tiempo [horas]: ");

            tiempo = int.Parse(Console.ReadLine());

            calcVelocidad();
        }

        public void calcVelocidad()
        {
            Console.WriteLine("La velocidad de desplazamiento es: " + distancia / tiempo + "km/h");
        }
    }
}
