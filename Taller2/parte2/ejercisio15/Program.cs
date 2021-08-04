using System;

namespace ejercisio15
{
    class Program
    {
        /*15.En un almacén se hace un 17% de descuento a los clientes cuya compra sea superior a $200.000,
            para las compras inferiores, el descuento será del 5%. ¿Cuánto deberá pagar cada cliente?*/
        static void Main(string[] args)
        {
            double  CantidadP;
            double total;
            double Descuento;

            Console.WriteLine("¿cuanto es la cantidad comprada en prendas?");
            CantidadP = int.Parse(Console.ReadLine());

            if (CantidadP > 200000)
            {
                Descuento = CantidadP * 0.17;
                total = CantidadP - Descuento;
                Console.WriteLine("la cantidad a pagar con el descuento seria de: " + total);
            }
            else
            {
                Descuento = CantidadP * 0.5;
                total = CantidadP - Descuento;
                Console.WriteLine("la cantidad a pagar con el descuento seria de: " + total );

            }
        }
    }
}
