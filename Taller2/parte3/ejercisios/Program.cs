using System;

namespace ejercisios
{
    class Program
    {
        private byte eleccion;

        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            do
            {
                Console.WriteLine("¿Que ejercisio desea realizar?");

                Console.WriteLine("1 --> saber la cantidad de numeros primos de un numero aleatorio \n2 --> saber el sueldo maximo de diferentes sueldos \n3 --> convertir un numero a escrito \n4 --> saber si una letra es vocal o consonante \n5 --> ninguno, salir");

                eleccion = byte.Parse(Console.ReadLine());

                if(eleccion == 1) new NumerosPrimos();
                
                else if(eleccion == 2) new SueldoMaximo();

                else if(eleccion == 3) new ConversionNumero();

                else if(eleccion == 4) new VocalConsonante();

                else 
                {
                    Console.WriteLine("Respuesta incorrecta, las posibles respuestas son: ");
                    Console.WriteLine("1 --> saber la cantidad de numeros primos de un numero aleatorio \n2 --> saber el sueldo maximo de diferentes sueldos \n3 --> convertir un numero a escrito \n4 --> saber si una letra es vocal o consonante \n5 --> ninguno, salir");
                }

            } while (eleccion != 5);

            Console.WriteLine("\nHas salido del programa, vuelve pronto");
        }
    }
}
