using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_migrado
{
    class Program
    {
        static void Main(string[] args)
        {

            //abro canal hacia el archivo
            System.IO.StreamReader archivo = null;

            try
            {

                string linea;

                int contador = 0;

                string path = @"C:\Users\Usuario\Desktop\archivo.txt";


                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la lectura del archivo");
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();

                    Console.WriteLine("El archivo se cerro");
                }
            }





        }


    }
}
