﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int numero = 5;
            int numero2 = 5;
            int resultado;


            resultado = numero + numero2;

            if(resultado > 10)
            {
                Console.WriteLine(resultado);
            //    Console.WriteLine("El numero "+ resultado + " Entro en el if");
                Console.WriteLine($"El numero  {resultado} Entro en el if");//interpolacion de string
            }
            else
            {
                Console.WriteLine(resultado);
              //  Console.WriteLine("El numero " + resultado + " Entro en el else");
                Console.WriteLine($"El numero  {resultado} Entro en el else");//interpolacion de string
            }

           



        }
    }
}
