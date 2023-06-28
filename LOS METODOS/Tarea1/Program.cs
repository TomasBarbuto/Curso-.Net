using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosCentigrados, radianes;
            bool esNumero;
            do
            {
                Console.Write("Ingrese los grados a convertir: ");
                esNumero = double.TryParse(Console.ReadLine(), out gradosCentigrados);

                if (!esNumero)
                {
                    Console.WriteLine("Debe ingresar un número");
                }

            } while (!esNumero);
            radianes = GradosARadianes(gradosCentigrados);

            Console.WriteLine($"{gradosCentigrados}°C en radianes son: {radianes}");
        }

        //Crear un método para transformar de grados a radianes
        public static double GradosARadianes(double grados)
        {
            return grados * Math.PI / 180;
        }
    }
}
