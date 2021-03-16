using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_migrado
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elija un numero del mes");
            int numero = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(nombreDelMes(numero));
            }
            catch (Exception e)
            {
                Console.WriteLine("El mensaje de erro es: " + e);
            }

            Console.WriteLine("Continua el programa");

        }


        public static String nombreDelMes(int mes)
        {

            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
