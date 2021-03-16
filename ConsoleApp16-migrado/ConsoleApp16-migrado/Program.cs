using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_migrado
{
    class Program
    {
        static void Main(string[] args)
        {

            CotizadorDolarPeso obj = new CotizadorDolarPeso();

            obj.ActualizaValorDolar(9);// en esta parte se le manda por parametro la nueva cotizacion de dolar


            Console.WriteLine(obj.Convierte(250.00));//en esta parte se manda el monto en pesos a cotizar en dolares



        }
    }





    class CotizadorDolarPeso
    {

        private double dolar = 130.00;//esta variable es privada


        public double Convierte(double cantidad) //metodo de calcular pesos a dolar
        {
            return cantidad * dolar;
        }


        public void ActualizaValorDolar(double valor)//metodo de actualizacion cortizacion dolar
        {
            if (valor < 0)
            {
                dolar = 130.00;
                Console.WriteLine("Se calcula la cotizacion vieja por ingreso negativo de pesos");
            }
            else
            {
                dolar = valor;
            }

        }



    }


}