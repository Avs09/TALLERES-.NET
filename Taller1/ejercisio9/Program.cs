using System;

namespace ejercisio9
{
    class Program
    {
        private double sueldoBase, sueldoTotal, venta1, venta2, venta3;
        private Boolean continuar;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            continuar = true;

            Console.Write("Ingrese el sueldo base: ");

            sueldoBase = double.Parse(Console.ReadLine());

            comisiones();
        }

        public void comisiones()
        {
            byte mes = 0;

            double comisionV1, comisionV2, comisionV3;

            while(continuar != false)
            {
                mes++;

                String confirmar;

                Console.Write($"¿Desea realizar tres ventas en el {mes} mes?");

                confirmar = Console.ReadLine();

                if(confirmar.Equals("si"))
                {
                    leerVentas();

                    comisionV1 = venta1 * 0.1;

                    comisionV2 = venta2 * 0.1;

                    comisionV3 = venta3 * 0.1;
                    
                    sueldoTotal = sueldoBase + (comisionV1 + comisionV2 + comisionV3);

                    getVentas(comisionV1, comisionV2, comisionV3, mes);
                }
                else if(confirmar.Equals("no")) continuar = false;

                else mes--; Console.WriteLine("Error, solo debes responder si o no");
            }
        }

        public void leerVentas()
        {
            Console.Write("Ingrese el dinero de la primera venta: ");

            venta1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el dinero de la segunda venta: ");

            venta2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el dinero de la tercera venta: ");

            venta3 = double.Parse(Console.ReadLine());
        }

        public void getVentas(double cV1, double cV2, double cV3, byte m)
        {
            Console.WriteLine($"\n*** VENTAS DEL {m} MES");

            Console.WriteLine("Ganancia por comisiones: $" + (cV1 + cV2 + cV3));

            Console.WriteLine("Ganancia de la primera comision: $" + cV1);

            Console.WriteLine("Ganancia de la segunda comision: $" + cV2);

            Console.WriteLine("Ganancia de la tercera comision: $" + cV3);

            Console.WriteLine("Ganancia total: $" + sueldoTotal);
        }
    }
}
