using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_migrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calcular(10, 5));



        }



        static double calcular(int num1, double num2)
        {

            double resultado;

            resultado = num1 / num2;

            return resultado;
        }




    }
}
