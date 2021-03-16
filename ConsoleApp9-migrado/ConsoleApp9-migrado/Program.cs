using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_migrado
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int miNumero = 101;
            int intentos = 0;

            //   Console.WriteLine($"Numero es {aleatorio} ");

            Console.WriteLine("Introduzca el numero");

            while (aleatorio != miNumero)
            {

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("No ha introducido un valor numerico valido");
                    Console.WriteLine(e.Message);
                    miNumero = 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("No ha introducido un valor numerico valido");
                    Console.WriteLine(e.Message);
                    miNumero = 0;
                }


                if (miNumero > aleatorio)
                {
                    Console.WriteLine("El numero ingresado es alto");
                }
                if (miNumero < aleatorio)
                {
                    Console.WriteLine("El numero ingresado es bajo");
                }
                intentos++;
            }
            Console.WriteLine($"Felicitaciones en numero es {miNumero} ");
            Console.WriteLine($"La cantidad de reintentos es: {intentos} ");


        }
    }
}
