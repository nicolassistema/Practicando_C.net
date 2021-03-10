using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //El desbordamiento no hace caer el programa por que visual studio tiene alto rendimiento y lo deja pasar 
            //la expresion "checked" no deja pasar el desbordamiento y hace caer el programa. 
            //Tambien se ppuede confirgurar para que siempre chequee "https://www.youtube.com/watch?v=vVRznsklCtI" en el minuto 17:39
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;


                Console.WriteLine(resultado);

            }



        }
    }
}
