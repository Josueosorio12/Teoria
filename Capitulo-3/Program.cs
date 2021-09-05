using System;

namespace Capitulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("1-Ejercicio 1 ");
                Console.WriteLine("2-Ejercicio 4 ");
                Console.WriteLine("3-Salir ");
                Console.Write("Elija una opcion: ");

                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (n)
                {
                    case 1:
                        Par_Impar();
                        break;
                    case 2:
                        Nombre_Del_Dia();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcion Invalidad ");
                        break;
                }

            } while (n != 3);
        }
        public static void Par_Impar()
        {
            int numero = 0;

            Console.Write("Este sistema dice si el numero es par o impar\n\n");
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par ");
            }
            else
            {
                Console.WriteLine("El numero es impar ");
            }
            Console.ReadLine();
        }
        public static void Nombre_Del_Dia()
        {
            int numero = 0;

            Console.Write("Este sistema dice que dia es de la semana\n\n ");
            Console.Write("\nIngrese un numero de dia: ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo"); break;

                default: Console.WriteLine("Error ese dia no existe "); break;
            }

            Console.ReadLine();
        }
    }
}
