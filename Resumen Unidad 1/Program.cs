using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumen_Unidad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un resumen de todos los temas de la Unidad1
             
             
            En la clase del día 18/07/2024 se vío las diferentes formas o metodos para 
            escribir una variable de tipo int, ente ellas: */

            int numero1 = 85;
            Console.WriteLine(numero1);
            byte numero2 = 255;
            Console.WriteLine(numero2);
            short numero3 = 1000;
            Console.WriteLine(numero3);
            long numero4 = 15;
            Console.WriteLine(numero4);


            //Para al clase del día 10/07/2024 se estudio con mayor profundidad. Se vió lo que son los
            //1. WriteLine -> Para ver el texto del código
            string nombre = "Marcelo";
            Console.WriteLine(nombre);
            //2.ReadLine -> Para que se pueda ingresar la informacion y que se pueda leer.
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();

            //3. Operaciones
            //Se vi la forma de calcular y realizar las 4 operaciones básica y el módulo
            //Suma, resta, multiplicación´, división y módulo.

            //4. Operadores Lógicos
            //Dentro de los operadores lógicos vimos
            /*  && las 2 condiciones deben ser verdadero para que me de el resultado true,
            *   || basta con que una condición sea verdader para que me de resultado true
            *   ! invierte el resultado, si es true a false y viceversa.
            */
            //5. Operadores Racionales
            //Aquí vimos los operadores mayor que, menor que, mayor igual que, menor igualque, igual u diferente a
            /*bool c1 = 20 > 90; 
            bool c2 = 0.85 < 1.25; 
            bool c3 = 88 == 88; 
            bool c4 = 25.3 != 25.3; 
            bool c5 = 85 >= 85.001; 
            bool c6 = 47.96 <= 36.96;

            Console.WriteLine("Los resultado son: ");
            Console.WriteLine($"20 > 90 es: ------->|{c1}");
            Console.WriteLine($"0.85 < 1.25 es ---->|{c2}");
            Console.WriteLine($"88 != 77 es ------->|{c3}");
            Console.WriteLine($"25.3 != 25.3 es --->|{c4}");
            Console.WriteLine($"85 >= 88.001 es --->|{c5}");
            Console.WriteLine($"47.96 <= 36.96 ---->|{c6}");

            //6. Palabras Reservadas
            Vimo lo que eran la palabras reservadas, palabras que no se puede utilizar para declarar variables por que tienen 
            su propia funcionalidad en los código.

            */


        }
    }
}
