using System;

namespace ejercisio1
{
    class Program
    {
        private double numero;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.Write("Ingrese un numero: ");

            numero = double.Parse(Console.ReadLine());

            numeroPar();
        }

        public void numeroPar()
        {
            String r = numero % 2 == 0 ? numero + " es par" : "";
            
            Console.WriteLine(r);
        }   
    }
}
