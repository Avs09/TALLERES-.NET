using System;

namespace ejercisio14
{
    class Program
    {
        //14.	Elaborar un algoritmo que lea un número, si es par, que imprima el cubo y si es impar, que imprima el triple.
        static void Main(string[] args)
        {
            int Num;


            Console.WriteLine("ingrese un numero");
            Num = int.Parse(Console.ReadLine());

            if (Num %2 == 0)
            {
                Num = Num * Num* Num *Num;

                Console.WriteLine("el cubo del numero digitado es de:" + Num);
            }
            else
            {
                Num = Num * 3;
                Console.WriteLine("el triple del numero digitado es de:" + Num);
            }
        }
    }
}
