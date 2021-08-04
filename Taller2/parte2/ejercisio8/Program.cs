using System;

namespace ejercisio8
{
    class Program
    {
    /* 8.Elaborar un algoritmo que permita calcular el número de
            pulsaciones que debe tener una persona por cada 10 segundos
            de ejercicio aeróbico; la fórmula que se aplica 
            cuando el sexo es femenino, es: 
            numpulsaciones = (220-edad)/10
            y si el sexo es masculino:
            numpulsaciones = (210-edad)/10*/

        static void Main(string[] args)
        {
            int edad;
            int Npulsaciones;
            string Genero ;


            Console.WriteLine("intoduce tu edad");
            edad = int.Parse(Console.ReadLine());


            Console.WriteLine("intoduce tu genero 'M' 'F'");
            Genero = Console.ReadLine();

            if (Genero == "F")
            {
                Npulsaciones = (220 - edad) / 10;
                Console.WriteLine("tus pulsacione cada 10 segundos deben de ser de:" + Npulsaciones);
            }
            else
            {
                Npulsaciones = (210 - edad) / 10;
                Console.WriteLine("tus pulsacione cada 10 segundos deben de ser de:" + Npulsaciones);
            }
        }
    }
}
