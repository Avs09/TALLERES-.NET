using System;

namespace ejercisio8
{
    class Program
    {
        private double interes, inversion;
        private byte tasaI;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese el dinero de inversion: ");

            inversion = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tasa de interes: ");

            tasaI = byte.Parse(Console.ReadLine());

            calcIntereses();
        }

        public void calcIntereses()
        {
            Boolean c = true;

            String confirmar = "si";

            do
            {
                interes += (inversion * tasaI) / 100;

                if(interes < 7000)
                {
                    Console.WriteLine("Intereses: $" + interes);

                    Console.WriteLine("Saldo total invertido: $" + (inversion + interes));

                    Console.Write("¿Desea reinvertir? ");

                    confirmar = Console.ReadLine();

                    if(confirmar.Equals("no")) c = false;
                }
                else
                {
                    Console.WriteLine("Los intereses han sobrepasado los $7000: $" + interes + " de intereses");

                    c = false;
                }

            }while(c != false);
        }
    }
}
