using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_ELSE_IF
{
    internal class Program
    {
        //Pedir un número al usuario y verificar si el número es positivo, negativo o cero
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número entero
            Console.WriteLine("Ingrese un numero entero");

            // Lee el número ingresado por el usuario desde la consola y lo convierte a un entero
            int num = int.Parse(Console.ReadLine());

            // Verifica si el número es mayor que 0
            if (num > 0)
            {
                // Si el número es mayor que 0, imprime que el número es positivo
                Console.WriteLine($"El numero {num} es positivo ");
            }
            // Verifica si el número es igual a 0
            else if (num == 0)
            {
                // Si el número es igual a 0, imprime que el número es cero
                Console.WriteLine($"El numero {num} es cero ");
            }
            // Si el número no es mayor que 0 ni igual a 0, entonces es negativo
            else
            {
                // Imprime que el número es negativo
                Console.WriteLine($"El numero {num} es negativo ");
            }

            // Espera a que el usuario presione una tecla    antes de cerrar la aplicación
            Console.ReadKey();
        }
        }
    }
