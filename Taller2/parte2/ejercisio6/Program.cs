using System;

namespace Ejercisio6
{
    class Program
    {
        /*6.Calcular e imprimir el salario de un empleado, 
            teniendo en cuenta que si el salario bruto es 
            igual o superior a $2.000.000, debe hacerse una
            retención del 10%, si el salario es inferior, 
            la retención será del 3%.*/
        static void Main(string[] args)
        {
            double SalarioB;
            double Retencion;
            double SalarioN;

            Console.WriteLine("ingrese su salario bruto");
            SalarioB = double.Parse(Console.ReadLine());


            if(SalarioB>= 2000000)
            {
                Retencion = SalarioB * 0.10;
                SalarioN = SalarioB - Retencion;
                Console.WriteLine("su salario es de: " + SalarioN);

            }
            else
            {
                Retencion = SalarioB * 0.3;
                SalarioN = SalarioB - Retencion;
                Console.WriteLine("su salario es de: " + SalarioN);
            }
        }
    }
}

