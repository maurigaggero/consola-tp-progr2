using System;

namespace preciokilo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Precio x kilo");
            Console.WriteLine(" ");

            Console.Write("Ingrese precio del producto 1 por kilo: ");
            double productoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad en kg: ");
            double cantA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese precio del producto 2 por kilo: ");
            double productoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad en kg: ");
            double cantB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese precio del producto 3 por kilo: ");
            double productoC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad en kg: ");
            double cantC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Total producto 1= " + productoA * cantA);

            Console.WriteLine(" ");
            Console.WriteLine("Total producto 2= " + productoB * cantB);

            Console.WriteLine(" ");
            Console.WriteLine("Total producto 3= " + productoC * cantC);

            double total = (productoA * cantA) + (productoB * cantB) + (productoC * cantC);

            if (total < 100)
            {
                Console.WriteLine(" ");
                Console.WriteLine("TOTAL DE COMPRA= " + total);
            }
            else
            {
                double descuento = total - (10 * total) / 100;
                Console.WriteLine(" ");
                Console.WriteLine("TOTAL CON DESCUENTO 10%= " + descuento);
            }

            Console.ReadKey();
        }
    }
}
