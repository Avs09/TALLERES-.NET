using System;

namespace ejercisio9
{
    class Program
    {
        /*9.	Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: 
        Si trabaja 40 horas o menos, se le paga a $10.000 la hora
        Si trabaja más de 40 horas, se le paga $10.000 por cada una de las primeras 40 horas
        y $15.000 por cada una de las horas extras.*/


        static void Main(string[] args)
        {
            int HorasT;
            int Costo = 10000;
            int PagoI;
            int HorasE;
            int PagoS;

            Console.WriteLine("cuantas horas trabajo en la semana ");
            HorasT= int.Parse (Console.ReadLine());

            if (HorasT <= 40)
            {
                PagoI = HorasT * Costo;
                Console.WriteLine("Su sueldo totoal equivale a: " + PagoI);
            } else
            {
                HorasE = HorasT - 40;
                PagoS = (40 * 10000) + (HorasE * 15000);
                Console.WriteLine("Su sueldo totoal equivale a: " + PagoS);
            }

        }
    }
}
