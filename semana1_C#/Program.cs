using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ejer4 ();
        }
        static void ejer1()
        {
            string nombre, carrera;
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu carrera");
            carrera = Console.ReadLine();
            Console.WriteLine($"\n{nombre}, bienvenido/a al curso de Fundamentos de Algoritmos de la carrera {carrera}");
            Console.ReadKey();

        }
        static void ejer2()
        {
            Console.Write("Ingresa tu numero X: ");
            int x = int.Parse( Console.ReadLine() );

            Console.Write("Ingresa tu numero Y: ");
            int y= int.Parse(Console.ReadLine());
            double resu = (double)x /(double) y;

            Console.WriteLine("suma: " + (x+y));
            Console.WriteLine("Resta: "+ (x-y));
            Console.WriteLine("Multiplicacion: " + (x * y));
            Console.WriteLine("Divicion: " +resu);
            Console.ReadKey();
        }
        static void ejer3()
        {
            Console.WriteLine("\"Ariana\"");

        }
        static void ejer4()
        {
            Console.Write("Ingrese un numero decimal: ");
            double num =Convert.ToDouble(Console.ReadLine());

            double raiz2= Math.Sqrt(num);
            int redo =(int)Math.Round(num);
            double cubo=Math.Pow(num, 3);
            double raiz3= Math.Pow(num, 1/3d);
            Console.WriteLine("Raiz 2: " + raiz2);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raiz 3: " + raiz3);
            Console.ReadKey();

        }
    }
}
