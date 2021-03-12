using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo miCirculo;
            double respuesta;
            miCirculo = new Circulo(); //aca se instancia el objeto

            respuesta = miCirculo.calculoArea(5); //guardo en varibale 

            Circulo miCirculo2 = new Circulo();//declaro objeto del tipo Circulo e instancio


            Console.WriteLine(miCirculo2.calculoArea(6));

            Console.WriteLine(respuesta);

        }
    }



   class Circulo //  esta es la clase o molde para construir diferentes instancias de objetos
    {
        const double pi = 3.1416;//propiedad de la clase

        public double calculoArea(double radio) //metodo de la clase
        {
            return pi * radio * radio;
        }

    }



}
