using System;

namespace ejercisio15
{
    class Program
    {
        private double monto, pago;
        private String cliente;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            leerDatos();

            getVentas();
        }

        public void leerDatos()
        {
            Console.Write("Cliente: ");

            cliente = Console.ReadLine();

            Console.Write("Ingrese el monto de venta: " );

            monto = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el pago por parte del cliente: ");

            pago = double.Parse(Console.ReadLine());
        }

        public void getVentas()
        {
            double iva = monto * 0.19;

            Console.WriteLine("*** REGISTRO DE VENTA ***");

            Console.WriteLine("Valor del iva (19%): $" + iva);

            Console.WriteLine("Total a pagar: $" + (monto + iva));

            Console.WriteLine("Cambio: $" + (pago - monto));
        }
    }
}
