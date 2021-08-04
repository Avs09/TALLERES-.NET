using System;

namespace ejercisio10
{
    class Program
    {
        /*10.Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo
            y desea saber cuántas calorías consume su cuerpo durante el tiempo
            que realice una misma actividad.Las actividades que puede realizar
            son únicamente dormir o estar sentado. Los datos que tiene son que
            estando dormido consume 1.08 calorías por minuto y estando sentado
            en reposo consume 1.66 calorías por minuto.*/
        static void Main(string[] args)
        {
            int opciones;
            double tiempo;
            double calorias;

            Console.WriteLine("Elige una opcion \n " );

            Console.WriteLine("\n opcion '1' estar dormido \n " + "opcion '2' estar sentado");
            opciones = int.Parse(Console.ReadLine());

            Console.WriteLine("cuantos minutos hizo la actividad:");
            tiempo = double.Parse(Console.ReadLine());

            if (opciones == 1)
            {
                calorias = tiempo * 1.08;
                Console.WriteLine("sus calorias gastadas son: " + calorias + " calorias");
            }else
            {
                calorias = tiempo * 1.66;
                Console.WriteLine("sus calorias gastadas son:  " + calorias + " calorias");
            }
        }
    }
}

