using System;

namespace ejercisio10
{
    class Program
    {
        private static double compra;
        static void Main(String[] args)
        {
            Console.Write("Ingrese el valor de la compra: ");

            compra = double.Parse(Console.ReadLine());

            totalCompra();
        }

        public static void totalCompra()
        {
            double descuento = compra * 0.15;

            Console.WriteLine("El total de la compra es: " + (compra - descuento));
        }
    }
}
