using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.
            int numero;
            bool esNumero;

            Console.Write("Ingrese un numero: ");
            esNumero = int.TryParse(Console.ReadLine(), out numero);

            if (esNumero)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }
            }
            else
            {
                Console.WriteLine("No ha ingresado un numero");
            }
        }
    }
}
