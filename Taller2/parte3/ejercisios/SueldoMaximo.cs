using System;

namespace ejercisios
{
    class SueldoMaximo
    {
        private double sueldo, numero;

        public SueldoMaximo()
        {
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
                Console.Write("Ingrese los sueldos: ");

                sueldo = double.Parse(Console.ReadLine());

                if(sueldo > numero)
                {
                    numero = sueldo;
                }

                Console.Write("¿Quiere ingresar mas sueldos?: ");

                confirmar = Console.ReadLine();

                if(confirmar.Equals("no")) continuar = false;

                else if(confirmar.Equals("si") == false) Console.WriteLine("Solo debes responder si o no");
            }

            Console.WriteLine("Sueldo maximo: $" + numero + "\n");
        }
    }
}