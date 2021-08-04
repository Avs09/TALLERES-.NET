using System;

namespace ejercisio11
{
    class Program
    {
        /*11.	Una empresa desea hacer una compra de varias piezas de la misma clase
                a una fábrica.La empresa, dependiendo del valor de la compra, decidirá
                la forma en que le pagará al fabricante.Si el valor de la compra 
                excede o es igual a $5.000.000, la empresa tendrá la capacidad de 
                pagar con recursos propios el 55% del valor de la compra, pedirá 
                prestado a un banco el 30% y el resto lo pagará solicitando un 
                crédito al fabricante. Si el monto total de la compra no excede 
                de $5.000.000, la empresa tendrá la capacidad de pagar con recursos 
                propios un 70% y el 30% restante, lo pagará solicitando un crédito 
                al fabricante.El fabricante cobra un 15% de interés sobre la cantidad
                que le pague a crédito*/
        static void Main(string[] args)
        {
            double ValorC;
            double RecursosP;
            double PrestamoB;
            double CreditoF;
            double NumeroP;
            double Costo;
            double intereses;

            
            Console.WriteLine("cuantas son las piezas que van a comprar: ");
            NumeroP = double.Parse(Console.ReadLine());

            Console.WriteLine("cual es el valor de las piezas que compraron");
            Costo = double.Parse(Console.ReadLine());

            ValorC = NumeroP * Costo;

            if (ValorC >= 5000000)
            {
                RecursosP = ValorC * 0.55;
                PrestamoB = ValorC * 0.30;
                CreditoF = ValorC * 0.15;

                Console.WriteLine("la inversion es de: " + RecursosP);
                Console.WriteLine("el prestamo del banco es de: " + PrestamoB);
                Console.WriteLine("el credito del fabricante es del:" + CreditoF);
            }
            else
            {
                RecursosP = ValorC * 0.70;
                CreditoF = ValorC * 0.30;
                intereses = CreditoF * 0.15;
                Console.WriteLine("la inversion es de: " + RecursosP);
                Console.WriteLine("el credito del fabricante es del:" + CreditoF);
                Console.WriteLine("los intereses de la empresa son de: " + intereses);

            }


        }
    }
}
