using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_migrado
{
    class Program
    {
        static void Main(string[] args)
        {


            // checked abreviado
            //el checked solo funciona con int y long

            int numero = int.MaxValue;
            int resultado = checked(numero + 20);


            Console.WriteLine(resultado);


            //unchecked(): cuando tenemos configurado en el proyecto que chequee todos los overflow, lo que hace es no chequear cierto overflow dejandolo pasar


            int resultado2 = unchecked(numero + 20);






        }
    }
}
