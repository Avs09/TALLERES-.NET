using System;

namespace ejercisio13
{
    class Program
    {
        /*13.	Una constructora ofrece vivienda de interés social, bajo las siguientes condiciones:
            Si los ingresos del comprador son iguales o superiores a $1.200.000, la cuota inicial
            será del 15% del valor de la vivienda y el resto, se distribuirá en 120 cuotas mensuales
            con un interés del 2% mensual.Si los ingresos del comprador son inferiores a $1.200.000,
            la cuota inicial será del 30% del valor de la vivienda y el resto, lo distribuirá en 84
            cuotas mensuales con un interés del 1% mensual.La constructora desea saber cuánto debe 
            pagar un comprador por concepto de cuota inicial y cuánto por cada cuota mensual.]*/
        static void Main(string[] args)
        {
            double valorI;
            double ValorC;
            double CuotaI;
            double CuotaM;

            Console.WriteLine("digite sus ingresos mensuales: ");
            valorI = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el precio de la casa ");
            ValorC = double.Parse(Console.ReadLine());

            if (valorI >= 1200000)
            {
                CuotaI = ValorC * 0.15;
                CuotaM = valorI * 0.2;

                Console.WriteLine("la cuota inicial de su casa seria de: " + CuotaI);
                Console.WriteLine("Y las cuotas mensuales serian : " + CuotaM);
            }
            else
            {
                CuotaI = ValorC * 0.30;
                CuotaM = valorI * 0.1;
                Console.WriteLine("la cuota inicial de su casa seria de: " + CuotaI);
                Console.WriteLine("Y las cuotas mensuales serian : " + CuotaM);
            }



        }
    }
}
