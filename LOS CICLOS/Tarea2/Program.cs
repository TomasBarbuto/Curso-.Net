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
            //Hacer un programa que calcule los numeros primos entre el 1 y el 100.

            int contador = 0;

            Console.WriteLine("Números primos entre 1 y 100\n");

            for (int num = 1; num <= 100; num++)
            {
                if (EsPrimo(num))
                    if (contador < 4)
                    {
                        Console.Write(num + ",");
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine(num);
                        contador = 0;
                    }   
            }

        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                        return false;
                }
            }
            return true;
        }
    }
}
