using System;

namespace ejercisio6
{
    class Program
    {
        private static double salarioBruto, salarioNeto, retencion;
        private static String empleado;
        static void Main(string[] args)
        {
            Console.Write("Nombre del empleado: ");

            empleado = Console.ReadLine();

            calcSalario();

            Console.WriteLine("\nEmpleado: " + empleado);

            Console.WriteLine("Salario bruto: " + salarioBruto + "$");

            Console.WriteLine("Retencion del 10%: " + retencion + "$");

            Console.WriteLine("Salario neto: " + salarioNeto + "$");
        }

        public static void calcSalario()
        {
            Console.Write("Ingrese el salario: ");

            salarioBruto = double.Parse(Console.ReadLine());

            if(salarioBruto > 2000000)
            {
                retencion = salarioBruto * 0.1;
            }

            salarioNeto = salarioBruto - retencion;
        }
    }
}
