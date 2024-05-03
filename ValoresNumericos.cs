using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorNumerico
{
     class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, promedio;
            string linea;
            Console.Write("Ingresa el primer número: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingresa el segundo número: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingresa el tercer número: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Ingresa el cuarto número: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2 + num3 + num4;
                promedio = suma / 4;
            Console.Write("La suma de los cuatro números es: ");
            Console.WriteLine(suma);

            Console.Write("El Promedio de los cuatro números es: ");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}
