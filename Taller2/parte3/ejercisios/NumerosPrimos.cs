using System;

namespace ejercisios
{
    class NumerosPrimos
    {
        private int numero, cantidadP, divisible, contador;

        public NumerosPrimos()
        {
            Console.WriteLine("\n Selecionaste la opcion 1 --> saber la cantidad de numeros primos de un numero aleatorio");

            Console.WriteLine("*** BIENVENIDO AL PROGRAMA ***\n");
            
            Console.Write("Ingrese un numero aleatorio: ");

            numero = int.Parse(Console.ReadLine());

            Console.Write("Numeros primos: ");

            for(int i = 1; i <= numero; i++)
            {
                contador = 1;

                divisible = 0;

                while(contador <= i)
                {
                    if(i % contador == 0)
                    {
                        divisible++;
                    }

                    contador++;
                }

                if(divisible == 2)
                {
                    cantidadP++;

                    Console.Write(i + ". ");
                }
            }

            Console.WriteLine($"\nEntre 1 y {numero} hay {cantidadP} numeros primos\n");
        }
    }
}