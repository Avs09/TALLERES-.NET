using System;

namespace Ejercisio3
{
    class Program
    {
        /*3.Elabore un algoritmo que lea un número y si este es mayor o igual a 10
            devuelva el triple de este de lo contrario la cuarta parte de este.*/
        static void Main(string[] args)
        {
            double Num;
            double Num3;
            double Div;

            Console.WriteLine("escriba un numero");
            Num = double.Parse(Console.ReadLine());

            if (Num >= 10)
            {
                Num3 = Num * 3;
                Console.WriteLine("el triple del numero que pusiste es de:" +  Num3);
            }else
            {
                Div = Num / 4;
                Console.WriteLine("la cuarta parte del numero que pusiste es de:  " +  Div);
            }
        }
    }
}

