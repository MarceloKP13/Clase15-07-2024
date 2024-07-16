using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Unidad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sentencia if

            //bool numero = 5 > 3; //true o false
            bool numero1 = 2 > 8;

            if (numero && !numero1)
            {

            }
            else {*/


            // Pedir la edad por teclado y comprobar si la persona es mayor de edad

            Console.WriteLine("Ingrese su edad"); //Se muestra un texto para pedir la orden
            int edad = int.Parse(Console.ReadLine()); //Se define una variable y con .Parse se transforma
                                                      //la variable para que pueda ser leída

            if (edad >= 18) //Con la sentencia if se hace la comparcion entre el dato ingresado y la edad para mayoria de edad
            {
                Console.WriteLine($"Tiene {edad} años"); //si la edad es mayor o igual a 18 años se muestra este mensaje
                Console.WriteLine("Usted es MAYOR de edad");
            }else
            {
                Console.WriteLine($"Tiene {edad} años");//si la edad es menor a 18 se muestra este mensaje
                Console.WriteLine("Usted es MENOR de edad");
            }
            Console.ReadKey(); //Se agrega para que el programa no se cierre hasta qeu el usuario presione cualquie tecla
        }
    }
}
       
   
