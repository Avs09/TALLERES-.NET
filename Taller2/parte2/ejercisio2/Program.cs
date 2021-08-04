using System;

namespace ejercisio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Hacer un algoritmo que calcule el total a pagar por la compra de camisas.
            Si se compran tres camisas o más se aplica un descuento del 20 % sobre
            el total de la compra y si son menos de tres camisas un descuento del 10 %*/

            double TotalC;
            double ValorO;
            double ValorC;
            double Descuento;
            double TOtalD;

            Console.WriteLine("Cuantas camisas quieres llevar");
            TotalC = double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto cuesta las camisas o la camisa que quieres llevar");
            ValorC = double.Parse(Console.ReadLine());

            if (TotalC <= 3)
            {
                ValorO = TotalC * ValorC;
                Descuento = ValorO * 0.10;
                TOtalD = ValorO - Descuento;
                Console.WriteLine("Su monto a pagar con el descuento es de\n" + TOtalD);
            }
            else
            {
                ValorO = TotalC * ValorC;
                Descuento = ValorO * 0.20;
                TOtalD = ValorO - Descuento;
                Console.WriteLine("Su monto a pagar con el descuento es de" + "\n" + Descuento);
            }
        }
    }
}

