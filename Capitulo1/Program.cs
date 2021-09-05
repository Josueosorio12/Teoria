using System;

namespace Capitulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("1-Ejercicio 1 "); 
                Console.WriteLine("2-Ejercicio 5 ");
                Console.WriteLine("3-Salir ");
                Console.Write("Elija una opcion: "); 

                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Josue Osorio\n\n ");
                        break;
                    case 2:
                        Console.WriteLine("Josue Osorio \n"); 
                        Console.WriteLine("El exicto es la capacidad de ir de fracos en fracos sin perder el enstusiasmo.\n");
                        Console.WriteLine("Nunca eres demasiado viejo para marcarte otra meta o tener un nuevo sueño.\n"); 
                        Console.WriteLine("No dejes que tu pasado ocupe todo tu presente.\n");
                        Console.WriteLine("Lo que cuenta no es de dónde vienes, sino adónde vas.\n\n");
                        break;

                    case 3:
                        break;

                    default:
                       Console.WriteLine("Opcion Invalidad ");
                        break;
                }

            }while (n != 3);
            Console.ReadLine();
        }
    }
}
