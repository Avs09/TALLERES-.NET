using System;

namespace ejercisio20
{
    class Program
    {
        private String producto;
        private double precio, descuento;
        private int cantidad;

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese el producto a comprar: ");

            producto = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");

            precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad: ");

            cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el descuento: ");

            descuento = double.Parse(Console.ReadLine());

            calcFact();
        }

        public void calcFact()
        {
            double subTotal = precio * cantidad;

            double descuento = (subTotal * this.descuento) / 100;

            double iva = subTotal * 0.19;

            Console.WriteLine("*** Factura ***");

            Console.WriteLine("Producto: " + producto);

            Console.WriteLine("Cantidad: " + cantidad);

            Console.WriteLine("Sub total: $" + subTotal);

            Console.WriteLine("Iva (19%): $" + iva);

            Console.WriteLine("Descuento: " + this.descuento + "%");

            Console.WriteLine("Valor del descuento: $" + descuento);

            Console.WriteLine("Precio neto: " + (subTotal + iva));
        }
    }
}
