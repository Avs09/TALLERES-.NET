using System;

namespace ejercisio8
{
    class Program
    {
        private double inversion, ganancia;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            calcInversion();
        }

        public void calcInversion()
        {
            Console.Write("¿Desea invertir capital? ");

            String continuar = Console.ReadLine();

            if(continuar.Equals("si"))
            {
                Console.Write("Ingrese el dinero de inversion ");

                inversion += double.Parse(Console.ReadLine());

                ganancia = inversion * 0.02;

                Console.WriteLine("En el mes ha ganado: " + ganancia);
            }
            else if(continuar.Equals("no")) Console.WriteLine("Has salido del programa, vuelve pronto");

            else { Console.WriteLine("Error, solo debes responder si o no"); }

            Console.WriteLine("Ganancia total: " + (inversion + ganancia));
        }
    }
}
