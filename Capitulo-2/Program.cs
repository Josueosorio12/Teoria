using System;

namespace Capitulo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("1-Ejercicio 1 ");
                Console.WriteLine("2-Ejercicio 3 ");
                Console.WriteLine("3-Ejercicio 4 ");
                Console.WriteLine("4-Ejercicio 5 ");
                Console.WriteLine("5-Salir ");
                Console.Write("Elija una opcion: ");

                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (n)
                {
                    case 1:
                        Poligono();
                        break;
                    case 2:
                        Grados_Radianes();
                        break;
                    case 3:
                        Grados_Fahrenheit();
                        break;
                    case 4:
                        Dolar_Euro();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcion Invalidad ");
                        break;
                }
            } while (n != 5);
        }
        public static void Poligono()
        {
            double perimetro, x = 0, y = 0;
            Console.WriteLine("Ingrese los lados del poligono: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho del poligono: ");
            y = Convert.ToInt32(Console.ReadLine());

            perimetro = x * y;

            Console.WriteLine("El resultado del poligono es: {0} ",perimetro);
        }
        public static void Grados_Radianes()
        {
            const double pi = 3.1416;
            double grados, radianes;

            Console.Write("Este Sistema convierte de grados a radianes\n\n");
            Console.Write("Ingrese los grados a convertir: ");
            grados = double.Parse(Console.ReadLine());

            radianes = (grados * pi) / 180;

            Console.WriteLine("\nEl equivalente en radianes es: {0}°", radianes);
        }
        public static void Grados_Fahrenheit()
        {
            double fahrenheit = 0, centigrado = 0;
            Console.WriteLine("Ingrese la cantidad de centigrados a convertir a fahrenheit: ");
            centigrado = Convert.ToInt32(Console.ReadLine());

            fahrenheit = (centigrado * 9 / 5) + 32;
            Console.WriteLine("El resultado es {0}° ", fahrenheit);



        }

        public static void Dolar_Euro()
        {
            double dolar, euro, tipocambio;

            Console.Write("Este Sistema Convierte de dolares a euros\n ");
            Console.Write("\nIngrese la cantidad de dolares a convertir a euro: ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("\nIngrese tipo de cambio del dia: ");
            tipocambio = double.Parse(Console.ReadLine());

            euro = dolar * tipocambio;

            Console.WriteLine("\n la cantidad en euros  es: {0}$", euro);
            Console.ReadLine();
        }

    }
}
