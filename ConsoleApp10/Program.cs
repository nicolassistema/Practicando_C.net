using System;

namespace ConsoleApp8
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
                //Cacheo de arrores con filtro
                catch (Exception e) when (e.GetType()!=typeof(FormatException))//cachea el error que sea distinto de FormatException
                {
                    Console.WriteLine("No ha introducido un valor numerico valido");
                    Console.WriteLine(e.Message);
                    miNumero = 0;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ha introducido texto");
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
