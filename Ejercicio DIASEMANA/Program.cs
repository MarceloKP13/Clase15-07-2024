using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_DIASEMANA
{
    internal class Program
    {
        //PEDIR POR TECLADO UN DÍA DE LA SEMANA E IMPRIMIR CUANTAS LETRAS TIENE ESE DÍA
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un día de la semana");
            string dia = Console.ReadLine().ToLower();
            string palabra = "";
            int numero = 0;

            switch (dia){
                case "lunes":
                    palabra = "Lunes"; 
                    numero = 5;
                    break;
                case "martes":
                    palabra = "Martes";
                    numero = 6;
                    break;
                case "miercoles":
                    palabra = "Miércoles";
                    numero = 9;
                    break;
                case "jueves":
                    palabra = "Jueves";
                    numero = 6;
                    break;
                case "viernes":
                    palabra = "Viernes";
                    numero = 7;
                    break;
                case "sabado":
                    palabra = "Sábado";
                    numero = 6;
                    break;
                case "domingo":
                    palabra = "Domingo";
                    numero = 7;
                    break;
                default:
                    palabra = "Día no válido";
                    break;
            }
            Console.WriteLine($"El día {palabra} tiene {numero} letras.");
            Console.ReadKey();
        }
    }
}
