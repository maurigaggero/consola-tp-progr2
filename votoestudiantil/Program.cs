using System;

namespace votoestudiantil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VOTACION ESTUDIANTIL ");
            Console.WriteLine("");


            Console.Write("INTRODUZCA CANTIDAD VOTOS JUAN: ");
            int cantJuan = Convert.ToInt32(Console.ReadLine());

            Console.Write("INTRODUZCA CANTIDAD VOTOS PABLO: ");
            int cantPablo = Convert.ToInt32(Console.ReadLine());

            Console.Write("INTRODUZCA CANTIDAD VOTOS SANTIAGO: ");
            int cantSantiago = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");


            int totalVotos = cantJuan + cantPablo + cantSantiago;

            //ACUMULADORES
            int mayor = 0;
            int menor = 0;


            if (cantJuan > cantPablo && cantJuan > cantSantiago)
            {
                Console.WriteLine("Juan es el ganador y obtuvo " + cantJuan + " votos");
                Console.WriteLine(cantJuan * 100 / totalVotos + " % del total de votos");

                mayor = cantJuan;
            }

            if (cantPablo > cantJuan && cantPablo > cantSantiago)
            {
                Console.WriteLine("Pablo es el ganador y obtuvo " + cantPablo + " votos");
                Console.WriteLine(cantPablo * 100 / totalVotos + " % del total de votos");

                mayor = cantPablo;
            }

            if (cantSantiago > cantJuan && cantSantiago > cantPablo)
            {
                Console.WriteLine("Santiago es el ganador y obtuvo " + cantSantiago + " votos");
                Console.WriteLine(cantSantiago * 100 / totalVotos + " % del total de votos");

                mayor = cantSantiago;
            }


            /////////////////////////////////////////////////////////////////////////////////////


            if (cantJuan < cantPablo && cantJuan < cantSantiago)
            {
                Console.WriteLine("Juan es el que obtuvo menos votos");

                menor = cantJuan;
            }

            if (cantPablo < cantJuan && cantPablo < cantSantiago)
            {
                Console.WriteLine("Pablo es el que obtuvo menos votos");

                menor = cantPablo;
            }

            if (cantSantiago < cantJuan && cantSantiago < cantPablo)
            {
                Console.WriteLine("Santiago es el que obtuvo menos votos");

                menor = cantSantiago;
            }

            Console.WriteLine("La diferencia es de: " + (mayor - menor) + " votos");

            Console.ReadKey();
        }
    }
}
