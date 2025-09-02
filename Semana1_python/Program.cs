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
            ejer1();
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
    }
}
