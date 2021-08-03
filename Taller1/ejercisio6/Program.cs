using System;

namespace ejercisio6
{
    class Program
    {
        private double compra, valorTotal, iva, descuento;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese el valor de la compra: ");

            compra = double.Parse(Console.ReadLine());

            Console.Write("¿Desea aplicar descuento del 10%? ");

            String opcion = Console.ReadLine();

            calcValorT(opcion);

            Console.WriteLine("El valor total de la compra es: $" + valorTotal);

            Console.WriteLine("Valor del 19% de iva: $" + iva);

            Console.WriteLine($"Descuento del 10%: ${descuento}, {opcion} aplica");
        }

        public void calcValorT(String o)
        {
            iva = compra * 0.19;

            if(o.Equals("si")) 
            {
                descuento = compra * 0.1;
                
                valorTotal = compra - descuento + iva;
            }
            else if(o.Equals("no")) valorTotal = compra + iva;

            else Console.WriteLine("Error, solo debes responder si o no");
        }
    }
}
