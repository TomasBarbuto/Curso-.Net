using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcule el perímetro de cualquier polígono regular.

            //Area = (perimetro * apotema) / 2
            //Perimetro = (lado * numero de lados)
            //Apotema = (lado / 2) * tan(180 / numero de lados)

            //Cantidad de lados.
            int cantidadDeLados;
            bool esCantidadDeLados;
            //Longitud de los lados.
            float LongitudDelados;
            bool esLados;
            //Resultados y derivadas.
            float apotema, perimetro, area;

            Console.WriteLine("Dame el numero de lados del poligono");
            esCantidadDeLados = int.TryParse(Console.ReadLine(), out cantidadDeLados);

            Console.WriteLine("Dame la longitud de los lados");
            esLados = float.TryParse(Console.ReadLine(), out LongitudDelados);
            
            if (esCantidadDeLados && esLados)
            {
                apotema = (float)((LongitudDelados / 2) * Math.Tan(180.0 / cantidadDeLados));
                perimetro = LongitudDelados * cantidadDeLados;
                area = (perimetro * apotema) / 2;

                Console.WriteLine($"El area es = {area}");
                Console.WriteLine($"El perimetro es = {perimetro}");
            }
            else
            {
                Console.WriteLine("No Ingresaste Numeros");
            }

            Console.ReadKey();
        }
    }
}
