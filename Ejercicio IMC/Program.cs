using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su peso en kilogramos:");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en metros:");
            float altura = float.Parse(Console.ReadLine());

            float imc = (float) (peso / Math.Pow(altura,2.0));

            Console.WriteLine($"Su IMC es: {imc}");

            if (imc < 16.5)
            {
                Console.WriteLine("Interpretación: Bajo peso severo");
            }
            else if (imc >= 16.5 && imc < 18.5)
            {
                Console.WriteLine("Interpretación: Bajo Peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Interpretación: Peso Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Interpretación: Sobrepeso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Interpretación: Obesidad tipo 1 (moderada)");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Interpretación: Obesidad tipo 2 (severa)");
            }
            else
            {
                Console.WriteLine("Interpretación: Obesidad tipo 3 (mórbida)");
            }

            Console.ReadKey();
        }
    }
}
