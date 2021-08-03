using System;

namespace ejercisio17
{
    class Program
    {
        private double salario, ahorroMensual;

        private String empleado;

        static void Main(string[] args)
        {
            Program empleado1 = new Program();

            empleado1.colillaPago();
        }

        public Program()
        {
            Console.Write("Nombre del empleado: ");

            empleado = Console.ReadLine();

            Console.Write("Ingrese el salario: ");

            salario = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el ahorro mensual: ");

            ahorroMensual = double.Parse(Console.ReadLine());
        }

        public void colillaPago()
        {
            double salud = salario * 0.125;

            double pension = salario * 0.16;

            Console.WriteLine("*** COLILLA DE PAGO ***");

            Console.WriteLine("Empleado: " + empleado);

            Console.WriteLine("Salario: $" + salario);

            Console.WriteLine("Valor del ahorro mensual: $" + ahorroMensual);

            Console.WriteLine("Valor por parte de la salud: $" + salud);

            Console.WriteLine("Valor por parte de la pension: $" + pension);

            Console.WriteLine("Total a recibir: $" + (salario - salud - pension));
        }
    }
}
