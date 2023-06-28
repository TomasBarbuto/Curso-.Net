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
            int opcion;
            double radio, lado, baseTriangulo, altura;
            bool esNumero;

            // Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de  los 3 métodos.
            do
            {
                Console.WriteLine("¿Qué figura desea calcular el área?");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese el número de la opción: ");
                opcion = int.Parse(Console.ReadLine());

                //crear un switch para cada caso segun la opcion
                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingrese el radio del círculo: ");
                            esNumero = double.TryParse(Console.ReadLine(), out radio);

                            if (!esNumero)
                            {
                                Console.WriteLine("Debe ingresar un número");
                            }

                        } while (!esNumero);

                        Console.WriteLine($"El área del círculo es: {CalcularAreaCirculo(radio)}");
                        break;
                    case 2:
                        do
                        {
                            Console.Write("Ingrese el lado del cuadrado: ");
                            esNumero = double.TryParse(Console.ReadLine(), out lado);

                            if (!esNumero)
                            {
                                Console.WriteLine("Debe ingresar un número");
                            }

                        } while (!esNumero);

                        Console.WriteLine($"El área del cuadrado es: {CalcularAreaCuadrado(lado)}");
                        break;
                    case 3:
                        do
                        {
                            Console.Write("Ingrese la base del triángulo: ");
                            esNumero = double.TryParse(Console.ReadLine(), out baseTriangulo);

                            if (!esNumero)
                            {
                                Console.WriteLine("Debe ingresar un número");
                            }

                        } while (!esNumero);

                        do
                        {
                            Console.Write("Ingrese la altura del triángulo: ");
                            esNumero = double.TryParse(Console.ReadLine(), out altura);

                            if (!esNumero)
                            {
                                Console.WriteLine("Debe ingresar un número");
                            }

                        } while (!esNumero);

                        Console.WriteLine($"El área del triángulo es: {CalcularAreaTriangulo(baseTriangulo, altura)}");
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar el programa");
                        break;

                    default:
                        Console.WriteLine("Debe ingresar una opción válida");
                        break;
                }   

            }
            while (!(opcion >= 1 && opcion <= 4));
            
        }

        //Crear una metodo que calcule el área de un triangulo.
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        //crear un método para calcular el área de un cuadrado
        public static double CalcularAreaCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        //crear una metodo para calcular area de un triangulo
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }
    }
}
