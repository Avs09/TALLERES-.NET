using System;

namespace Ejercisios5
{
    class Program
    {
        /*5.Determinar el precio de un pasaje de ida y vuelta por avión, 
            conociendo la distancia a recorrer y sabiendo que que esta es
            superior a 1.000 km, la línea aérea le hace un descuento del 30%.
            El precio por kilómetro es de $150.*/
        static void Main(string[] args)
        {
            double DistanciaR;
            double PresioB;
            Double Descuentos;
            double Total;
            int PrecioK = 150;


            Console.WriteLine("Cuantos kilometros va a recorrer ");
            DistanciaR = double.Parse(Console.ReadLine());

            if (DistanciaR >= 1000)
            {
                PresioB = DistanciaR * PrecioK;
                Descuentos = PresioB * 0.30;
                Total = PresioB - Descuentos;

                Console.WriteLine("El total de su viaje es de: " + Total);
            }
            else
            {
                PresioB = DistanciaR * PrecioK;
                Console.WriteLine("El precio de su viaje es de: "  + PresioB);
            }

        }
    }
}