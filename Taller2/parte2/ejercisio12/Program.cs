using System;

namespace ejercisio12
{
    class Program
    {
        /*12.Elaborar un algoritmo que permita calcular el valor 
            total a pagar en una papelería teniendo en cuenta que,
            si lleva 5 cuadernos o más, se le cobrarán $2.000 por
            cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por cada uno.*/
        static void Main(string[] args)
        {
            double precioC;
            double CuadernosA;

            Console.WriteLine("cuantos cuadernos vas a llevar");
            CuadernosA = double.Parse(Console.ReadLine());

            if (CuadernosA >= 5)
            {
                precioC = CuadernosA * 2000;
                Console.WriteLine("el precio de tu compra es de: " + precioC);
            }
            else
            {

                precioC = CuadernosA * 2500;
                Console.WriteLine("el precio de tu compra es de: " + precioC);
            }
        }
    }
}
