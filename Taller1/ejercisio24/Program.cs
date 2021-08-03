using System;

namespace ejercisio24
{
    class Program
    {
        private double monto, interesPrimerM, interesPrimerA, interesT;
        private String estudiante;

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Nombre del estudiante: ");

            estudiante = Console.ReadLine();

            Console.Write("Ingrese el monto del prestamo: ");

            monto = double.Parse(Console.ReadLine());

            calcInformacion();
        }

        public void calcInformacion()
        {
            double interesesM = (monto * 0.05) / 12;

            interesPrimerM = interesesM * 1;

            interesT = interesesM * 9;

            interesPrimerA = interesesM * 12;

            Console.WriteLine("Pago de interes en el primer año: $" + interesPrimerA);

            Console.WriteLine("Pago de interes en el tercer trimestre del primer año: $" + interesT);

            Console.WriteLine("Pago de interes en el primer mes: $" + interesPrimerM);

            Console.WriteLine("Pago total: $" + (monto + (monto * 0.05) * 5));

            
        }
    }
}
