using System;

namespace ejercisios
{
    class ConversionNumero
    {
        private int numero;
        private String unidades, decenas;

        public ConversionNumero()
        {
            Console.Write("Ingrese un numero entre 0 y 99: ");

            numero = int.Parse(Console.ReadLine());

            while(numero < 0 || numero > 99)
            {
                Console.Write("Fuera de rango, ingrese un numero entre 0 y 99: ");

                numero = int.Parse(Console.ReadLine());
            }

            double uni = numero % 10;

            double dec = numero / 10;

            convert(uni, dec);

            Console.WriteLine($"{numero}, es igual a: {decenas + unidades}\n");
        }

        public void convert(double u, double d)
        {
            switch (u)
            {
                case 0:
                    unidades = "Cero";

                    if(d == 1) { decenas = "Diez"; unidades = ""; }

                    else if(d == 2) { decenas = "Veinte"; unidades = ""; }

                    else if(d == 3) { decenas = "Treinta"; unidades = ""; }

                    else if(d == 4) { decenas = "Cuarenta"; unidades = ""; }

                    else if(d == 5) { decenas = "Cincuenta"; unidades = ""; }

                    else if(d == 6) { decenas = "Sesenta"; unidades = ""; }

                    else if(d == 7) { decenas = "Setenta"; unidades = ""; }

                    else if(d == 8) { decenas = "Ochenta"; unidades = ""; }

                    else if(d == 9) { decenas = "Noventa"; unidades = ""; }
                break;

                case 1:
                    unidades = "uno";

                    if(d == 1) { decenas = "On"; unidades = "ce"; }

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y ";

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";  

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y "; 
                break;

                case 2:
                    unidades = "dos";

                    if(d == 1) { decenas = "Do"; unidades = "ce"; }

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y ";

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y "; 
                break;

                case 3:
                    unidades = "tres";

                    if(d == 1) { decenas = "Tre"; unidades = "ce"; }

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y "; 

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y ";
                break;

                case 4:
                    unidades = "cuatro";

                    if(d == 1) { decenas = "Cator"; unidades = "ce"; }

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y ";

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y ";
                break;

                case 5:
                    unidades = "cinco";

                    if(d == 1) { decenas = "Quin"; unidades = "ce"; }

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y ";

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y "; 
                break;

                case 6:
                    unidades = "seis";

                    if(d == 1) decenas = "Dieci"; 
                    
                    else if(d == 2) decenas = "Veinti"; 

                    else if(d == 3) decenas = "Treinta y "; 

                    else if(d == 4) decenas = "Cuarenta y "; 

                    else if(d == 5) decenas = "Cincuenta y "; 

                    else if(d == 6) decenas = "Sesenta y "; 

                    else if(d == 7) decenas = "Setenta y "; 

                    else if(d == 8) decenas = "Ochenta y "; 

                    else if(d == 9) decenas = "Noventa y "; 
                break;

                case 7:
                    unidades = "siete";
                    if(d == 1) decenas = "Dieci";

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y ";

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y ";
                break;

                case 8:
                    unidades = "ocho";

                    if(d == 1) decenas = "Dieci";

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y ";

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y ";
                break;

                case 9:
                    unidades = "nueve";

                    if(d == 1) decenas = "Dieci";

                    else if(d == 2) decenas = "Veinti";

                    else if(d == 3) decenas = "Treinta y ";

                    else if(d == 4) decenas = "Cuarenta y ";

                    else if(d == 5) decenas = "Cincuenta y ";

                    else if(d == 6) decenas = "Sesenta y ";

                    else if(d == 7) decenas = "Setenta y ";

                    else if(d == 8) decenas = "Ochenta y ";

                    else if(d == 9) decenas = "Noventa y ";
                break;

                default:
                    Console.WriteLine("Error");
                break;
            }
        }
    }
}