using System;

namespace ejercisio13
{
    class Program
    {
        private double compra;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese el valor del producto: ");

            compra = double.Parse(Console.ReadLine());

            calcCompra();
        }

        public void calcCompra()
        {
            double iva = compra * 0.16;

            double descuento = compra * 0.1;

            if(compra >= 1000000)
            {
                double valorTotal = compra = (compra - descuento) + iva;

                Console.WriteLine("Valor del 10% de descuento: " + descuento + "$");

                Console.WriteLine("Valor total con descuento: " + (compra - descuento) + "$");

                Console.WriteLine("Valor del 19% de iva es: " + iva + "$");

                Console.WriteLine("Valor total con iva: " + (compra + iva) + "$");

                Console.WriteLine("VALOR TOTAL: " + valorTotal + "$");
            }
        }
    }
}
