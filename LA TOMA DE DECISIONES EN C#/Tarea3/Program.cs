using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00

            int tiempo;
            bool esNumero;

            Console.Write("Ingrese el tiempo que ha permanecido en el estacionamiento(Minutos): ");
            esNumero = int.TryParse(Console.ReadLine(), out tiempo);

            if (esNumero)
            {
                if (tiempo <= 60)
                {
                    Console.WriteLine("El precio a pagar es de $5.00");
                }
                else if (tiempo <= 120)
                {
                    Console.WriteLine("El precio a pagar es de $15.00");
                }
                else
                {
                    Console.WriteLine("El precio a pagar es de $40.00");
                }
            }
            else
            {
                Console.WriteLine("No ha ingresado un numero");
            }
        }
    }
}
