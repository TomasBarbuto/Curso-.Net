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
            //Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.

            int baseNum, exponente, resultado;
            bool esNumeroBase, esNumeroExponente;

            Console.Write("Ingrese la base: ");
            esNumeroBase = int.TryParse(Console.ReadLine(), out baseNum);

            Console.Write("Ingrese el exponente: ");
            esNumeroExponente = int.TryParse(Console.ReadLine(), out exponente);

            //Lo inicializamos en 1 por si el exponente es 0.
            resultado = 1;

            if (esNumeroBase && esNumeroExponente)
            {
                if (exponente > 0)
                {
                    for (int i = 0; i < exponente; i++)
                    {
                        resultado = resultado * baseNum;
                    }
                    Console.WriteLine("El resultado es: " + resultado);
                }
                else if (exponente < 0)
                {
                    for (int i = 0; i > exponente; i--)
                    {
                        resultado = resultado * baseNum;
                    }
                    Console.WriteLine("El resultado es: " + 1 / resultado);
                }
                else
                {
                    Console.WriteLine("El resultado es: " + resultado);
                }
            }
            else
            {
                Console.WriteLine("Ingrese solo numeros");
            }
            

        }
    }
}
