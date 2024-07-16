using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_Switch
{
    internal class Program
    {
        //Recibe como argumentos un valor y lo evalua en casos
        static void Main(string[] args)
        {
            string msm = "";

            switch (0) {
                case 0:
                    msm = "Es número cero";
                    break;
                case 1:
                    msm = "Es número uno";
                    break;
                case 2:
                    msm = "Es número dos"; 
                    break;
                default:
                    msm = "error argumento no válido;";
                    break;
            }

            Console.WriteLine(msm);
            Console.ReadKey();
        }
    }
}
