using System;

namespace ejercisios
{
    class SueldoMaximo
    {
        private double sueldo, numero;

        public SueldoMaximo()
        {
            Console.WriteLine("\nSelecionaste la opcion 2 --> saber el sueldo maximo de diferentes sueldos");

            Console.WriteLine("*** BIENVENIDO AL PROGRAMA ***\n");
            
            Console.Write("Ingrese un numero: ");

            numero = double.Parse(Console.ReadLine());

            calcSueldoM();
        }

        public void calcSueldoM()
        {
            Boolean continuar = true;

            String confirmar;

            while(continuar != false)
            {
                Console.Write("¿Quiere ingresar sueldos?: ");

                confirmar = Console.ReadLine();

                if(confirmar.Equals("no")) continuar = false;

                else if(confirmar.Equals("si"))
                {
                    Console.Write("Ingrese los sueldos: ");

                    sueldo = double.Parse(Console.ReadLine());
                } 
                else Console.WriteLine("Solo debes responder si o no");

                if(sueldo > numero)
                {
                    numero = sueldo;
                }
            }

            Console.WriteLine("Sueldo maximo: $" + numero + "\n");
        }
    }
}