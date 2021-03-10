using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int salida = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                int numero = int.Parse(Console.ReadLine());

                // int resultado = numero % 2;

                if ((numero % 2) == 0)
                {
                    Console.WriteLine("Es numero par");
                }
                else
                {
                    Console.WriteLine("Es numero impar");
                }

                Console.WriteLine("sale??");
                salida = int.Parse(Console.ReadLine());

            } while (salida == 0);



        }
    }
}
