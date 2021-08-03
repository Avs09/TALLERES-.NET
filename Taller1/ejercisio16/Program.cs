using System;

namespace ejercisio16
{
    class Program
    {
        private double valor, recaudo;
        private int pasajero;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            calcGanancia();

            Console.WriteLine("\nCantidad de pasajeros: " + pasajero);

            Console.WriteLine("Total recaudo: $" + recaudo);

            Console.WriteLine("Valor por pasajero: $" + valor);

            Console.WriteLine("Ganancia: " + recaudo * 0.19);
        }

        public void calcGanancia()
        {
            Console.Write("Ingrese la cantidad de pasajeros: ");

            pasajero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio de subida: ");

            valor = double.Parse(Console.ReadLine());

            recaudo = pasajero * valor;
        }
    }
}
