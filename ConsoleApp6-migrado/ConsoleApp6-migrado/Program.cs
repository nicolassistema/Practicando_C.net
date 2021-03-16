using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_migrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumar(7, 8, 9));
        }


        //sobtre carga de metodos
        //el compilador identifica que metodo tiene que usar mediante los tipos y cantidad de datos
        static double sumar(double num1, double num2)
        {
            Console.WriteLine("Con dos terminos");
            return num1 + num2;
        }


        static double sumar(double num1, double num2, double num3)
        {
            Console.WriteLine("Con tres terminos");
            return num1 + num2 + num3;
        }

        //metodos con parametros opcionales dsonde num3 si no se le carga dato, por default va con 0
        static double sumar2(double num1, double num2, double num3 = 0)
        {
            return Resultado(num1, num2, num3);// se puede meter un metodo como return
        }

        private static double Resultado(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
    }
}
