using System;

namespace ejercisios
{
    class VocalConsonante
    {
        private Char letra;

        public VocalConsonante()
        {
            Console.Write("Ingrese una letra del abecedario: ");

            letra = Convert.ToChar(Console.ReadLine());

            validar();
        }

        public void validar()
        {
            while(Char.IsLetter(letra) == false)
            {
                Console.WriteLine("Error, debes ingresar una letra");

                letra = Char.Parse(Console.ReadLine());
            }

            if(letra.Equals('a') || letra.Equals('e') || letra.Equals('i') || letra.Equals('o') || letra.Equals('u')) Console.WriteLine("La letra " + letra + " es vocal");

            else Console.WriteLine("La letra " + letra + " es una consonante");
        }
    }
}