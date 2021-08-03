using System;

namespace ejercisio14
{
    class Program
    {
        private String[] articulos;
        private int[] unidades;
        private double[] valor;
        private double total, iva;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            articulos = new string[4];

            valor = new double[4];

            unidades = new int[4];

            for(int i = 0; i < articulos.GetLength(0); i++)
            {
                Console.Write("\nIngrese el articulo N°" + (i+1) + ": ");

                articulos[i] = Console.ReadLine();

                Console.Write("Ingrese el valor del articulo: ");

                valor[i] = double.Parse(Console.ReadLine());

                Console.Write("¿Cuantas unidades quiere llevar?: ");

                unidades[i] = int.Parse(Console.ReadLine());
            }

            getFactura();
        }
        public void getFactura()
        {
            Console.WriteLine("\n*** FACTURA ***");

            for(int i = 0; i < articulos.GetLength(0); i++)
            {
                Console.WriteLine("Articulo: " + articulos[i]);

                Console.WriteLine("Unidades: " + unidades[i]);

                Console.WriteLine("Precio del articulo: $" + valor[i]);

                Console.WriteLine("Valor del iva del articulo: $" + (valor[i] * unidades[i]) * 0.19 + "\n");

                iva += (valor[i] * unidades[i]) * 0.19;

                total+= (valor[i] * unidades[i]);

                if(i == 3)
                {
                    Console.WriteLine("Total iva: $" + iva);
                    Console.WriteLine($"Total a pagar: ${total+iva}"); 
                }
            }
        }
    }
}
