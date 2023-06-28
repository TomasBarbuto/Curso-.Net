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
            //trasnformar de grados centigrados a farenheit
            //F = (C * 9/5) + 32

            float gradosCentigrados, gradosFarenheit;
            bool esGradosCentigrados;

            Console.Write("Dame los grados centigrados: ");

            esGradosCentigrados = float.TryParse(Console.ReadLine(), out gradosCentigrados);

            if (esGradosCentigrados)
            {
                gradosFarenheit = (gradosCentigrados * 9 / 5) + 32;
                Console.WriteLine($"{gradosCentigrados}°C es igual a {gradosFarenheit}°F");
            }
            else
            {
                Console.WriteLine("Usted no ha ingresado un valor el cual podamos convertir.");
            }

            Console.ReadKey();
        }
    }
}
