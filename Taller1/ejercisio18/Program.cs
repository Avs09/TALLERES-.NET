using System;

namespace ejercisio18
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorM;

            Console.Write("Ingrese el valor de la matricula: ");

            valorM = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de la primera cuota: $" + valorMatricula(40, valorM));

            Console.WriteLine("Valor de la segunda cuota: $" + valorMatricula(25, valorM));

            Console.WriteLine("Valor de la tercera cuota: $" + valorMatricula(20, valorM));

            Console.WriteLine("Valor de la cuarta cuota: $" + valorMatricula(15, valorM));
        }

        public static double valorMatricula(byte c, double vM)
        {
            if(c == 40) return (vM * c) / 100;

            else if(c == 25) return (vM * c) / 100;

            else if(c == 20) return (vM * c) / 100;

            else if(c == 15) return (vM * c) / 100;

            else return 0;
        }
    }
}
