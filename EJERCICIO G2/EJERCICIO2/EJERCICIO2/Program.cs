using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            string sexo;
            string continuar;

           
                do {
                    Console.WriteLine("Ingresa tu nombre: ");
                    nombre = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Ingresa tu edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Ingresa tu sexo con el siguiente formato (Mujer - m) (Hombre - h): ");
                    sexo = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("\n");

                    if (sexo == "m")
                    {
                        Console.WriteLine($"La sra. {nombre} a sido registrada");
                        //Concatenacion interpolada
                    }else if (sexo == "h")
                    {
                        Console.WriteLine("El sr. " +  nombre + "a sido registrado");
                    }
                    else
                    {
                        Console.WriteLine("¡Error, debes de ingresar el sexo con el siguiente formato (Mujer - m) (Hombre - h)!");
                    }
                    Console.WriteLine("#########################################################################################");
                    Console.WriteLine("\n");
                    Console.WriteLine("Deseas continuar? s/n");
                    continuar = Console.ReadLine();
                    Console.Clear();
                    //Console.WriteLine("\n");
                    //Console.ReadKey();
                } while (continuar != "n");
                Console.WriteLine("Programa finalizado");
                Console.ReadKey();

        }
    }
}
