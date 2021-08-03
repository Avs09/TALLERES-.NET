using System;

namespace ejercisio5
{
    class Program
    {
        private String cliente;
        private double valorCompra;
        private Boolean continuar;
        static void Main(string[] args)
        {
            Program compras = new Program();

            compras.compra();
        }

        public void compra()
        {
            continuar = true;

            while(continuar)
            {
                Console.Write("¿desea realizar una compra? ");

                String confirmar = Console.ReadLine();

                if(confirmar.Equals("no")) continuar = false;
                    
                else if(confirmar.Equals("si"))
                {
                    Console.Write("Nombre del cliente: ");

                    cliente = Console.ReadLine();

                    calcPago();

                    Console.WriteLine($"Sr {cliente}, el total a pagar es: " + valorCompra + "$");
                }
                else Console.WriteLine("Error, solo existen dos posibles opciones [si/no]");
            }
        }
        public void calcPago()
        {
            Console.Write("Ingrese el valor de la compra: ");

            valorCompra = double.Parse(Console.ReadLine());

            if(valorCompra > 100000) valorCompra = valorCompra - (valorCompra * 0.2);
        }
    }
}
