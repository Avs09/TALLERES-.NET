using System;

namespace Ejercisio7
{
    class Program
    {
        //7.	Leer un número e imprimir un mensaje si es par o impar.
        static void Main(string[] args)
        {
            int Num;

            Console.WriteLine("escriba un numero");
            Num = int.Parse(Console.ReadLine());

            if( Num %2 == 0)
            {
                Console.WriteLine("Su numero es par");
            }else
            {
                Console.WriteLine("Su numero no es par");
            }
        }
    }
}
