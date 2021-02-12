using System; // es un namespace que contiene por ejemplo "console.writeline" (como una biblioteca)

namespace ConsoleApp3// es como una carpeta
{
    class Program //esto es una clase
    {

     



        static void Main(string[] args)//metodo
        {


            int numero1 = 5;
            int numero2 = 8;
            float resultado;
            int suma;
            int resultado2;
         //   int ingresoNumero1;
         //   int ingresoNumero2;


            resultado = (float)numero1 / numero2;

            Console.WriteLine("Hello World!"); // sentencia o instruccion que imprime por pantalla


            Console.WriteLine($"El resultado es {resultado}");

            Console.WriteLine("Ingrese un numero: ");
           int  ingresoNumero1 =int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero: ");
          int   ingresoNumero2 = int.Parse(Console.ReadLine());


         //   resultado2 = ingresoNumero1 + ingresoNumero2;

            Console.WriteLine($"El resultado de la operacion es: "+ (ingresoNumero1+ingresoNumero2));

            suma = Calcular(ingresoNumero1, ingresoNumero2);

            Console.WriteLine($"El resultado de la operacion funcion suma es: " + suma);


            int Calcular(int num1, int num2)
            {
                int suma;
                suma = num1 + num2;

                return suma;
            }


        }

    }
}
