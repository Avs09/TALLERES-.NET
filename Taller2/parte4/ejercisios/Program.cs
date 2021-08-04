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
            int contador = 1;

            for(int i = 0; i < contador; i++)
            {
                Console.WriteLine("¿Que ejercisio desea realizar?");

                Console.WriteLine("1 --> saber la cantidad de numeros primos de un numero aleatorio \n2 --> saber el sueldo maximo de diferentes sueldos \n3 --> convertir un numero a escrito \n4 --> saber si una letra es vocal o consonante \n5 --> ninguno, salir");

                eleccion = byte.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        new NumerosPrimos();
                    break;

                    case 2:
                        new SueldoMaximo();
                    break;

                    case 3:
                        new ConversionNumero();
                    break;

                    case 4:
                        new VocalConsonante();
                    break;

                    case 5:
                        Console.WriteLine("\nHas salido del programa, vuelve pronto");
                        
                        contador = 1;
                    break;

                    default:
                        Console.WriteLine("Respuesta incorrecta, las posibles respuestas son: ");
                        Console.WriteLine("1 --> saber la cantidad de numeros primos de un numero aleatorio \n2 --> saber el sueldo maximo de diferentes sueldos \n3 --> convertir un numero a escrito \n4 --> saber si una letra es vocal o consonante \n5 --> ninguno, salir");
                    break;
                }

                contador++;
            }
        }
    }
}

