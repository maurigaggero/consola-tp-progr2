using System;

namespace liquidacionsueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LIQUIDACION SUELDOS EMPRESA CONSTRUCTORA: ");
            Console.WriteLine("");

            Console.Write("INTRODUZCA LEGAJO: ");
            int legajo = Convert.ToInt32(Console.ReadLine());

            Console.Write("INTRODUZCA NOMBRE: ");
            string nombre = Console.ReadLine();

            Console.Write("INTRODUZCA CATEGORIA (A, B ó C): ");
            string categoria = Console.ReadLine();

            Console.Write("INTRODUZCA HORAS: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.Write("INTRODUZCA SUELDO BASICO: ");
            double basico = Convert.ToDouble(Console.ReadLine());

            //var obrero = (legajo, nombre, categoria, horas, basico);

            //Console.WriteLine("");
            //Console.WriteLine(obrero);
            Console.WriteLine("");


            if (categoria == "a" || categoria == "A")
            {
                double sueldoneto = basico + horas * 2.10;
                Console.WriteLine("Sueldo neto de " + nombre + " = " + sueldoneto);
            }

            if (categoria == "b" || categoria == "B")
            {
                double sueldoneto = basico + horas * 2.30;
                Console.WriteLine("Sueldo neto de " + nombre + " = " + sueldoneto);
            }

            if (categoria == "c" || categoria == "C")
            {
                double sueldoneto = basico + horas * 2.80;
                Console.WriteLine("Sueldo neto de " + nombre + " = " + sueldoneto);
            }

            Console.ReadKey();
        }
    }
}
