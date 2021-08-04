using System;

namespace _04
{
    class Program
    {
        //4.	Hacer un algoritmo que lea dos números y los imprima en orden ascendente
        static void Main(string[] args)
        {
            int Num1;
            int Num2;

            Console.WriteLine("ingrese el primer numero: ");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            Num2 = int.Parse(Console.ReadLine()+ "\n");

            if (Num1 < Num2)
            {

                Console.WriteLine("los numeros en forma ascendente son: ");
                Console.WriteLine(Num1+"\n");
                Console.WriteLine(Num2);
                Console.WriteLine();
                
            }
            else
            {
                Console.WriteLine("los numeros en forma ascendente son: ");
                Console.WriteLine(Num2 + "\n");
                Console.WriteLine(Num1);
            } 
        }
    }
}

