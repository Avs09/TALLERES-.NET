using System;

namespace Ejercisio1
{
    /*1.  Hacer un algoritmo que imprima el nombre de un artículo,
        clave, precio original y su precio con descuento.El descuento
        lo hace en base a la clave, si la clave es 01 el descuento es
        del 10% y si la clave es 02 el descuento es del 20% (solo existen dos claves).*/
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("vamos a hacer un algoritmo que imprima la informacion del articulo ");

            String NombreP;
            String Clave;
            double PrecioC;
            double Descuentos;
            double precioD;

            Console.WriteLine("escribe el nombre del producto");
            NombreP = Console.ReadLine();

            Console.WriteLine("escribe la clabe del producto segun tu prenda ´01,02´ ");
            Clave = Console.ReadLine();

            Console.WriteLine("escribe el precio del producto");
            PrecioC = double.Parse (Console.ReadLine());

            if (Clave == "01" || Clave == "02")
            {
                if (Clave == "01")
                {
                    Descuentos = PrecioC * .10;
                    precioD = PrecioC - Descuentos;
                }
                else
                {
                    Descuentos = PrecioC * .20;
                    precioD = PrecioC - Descuentos;
                }

                Console.WriteLine("El Nombre de su articulo es:" + NombreP+ "\n" + "El presio original de su producto es de: " + PrecioC + "\n" + "La clave de su articulo fue: " + Clave + "\n" + "El precio con descuelto de su producto fue de:" + precioD + "\n");

            }else
            {
                Console.WriteLine("Escribe la clave correcta");
            }   
        }
    }
}
