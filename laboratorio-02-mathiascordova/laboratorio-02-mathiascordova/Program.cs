using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_02_mathiascordova
{
    class Program
    {
        static void Main(string[] args)
        {
            string seleccion;
            Espotifai spotify = new Espotifai();
            Console.WriteLine("Bienvenido a Espotifai!");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Indicar el numero al que se quiere acceder:");
                Console.WriteLine("1. Ver canciones");
                Console.WriteLine("2. Agregar una cancion");
                Console.WriteLine("3. Salir de Espotifai");
                seleccion = Console.ReadLine();
                if (seleccion == "1")
                {
                    spotify.VerCanciones();
                }
                if (seleccion == "2")
                {
                    Console.WriteLine("Escriba nombre, album, artista y genero (en ese orden)");
                    Console.WriteLine(spotify.AgregarCancion(new Cancion(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
                }
                else if (seleccion == "3")
                {
                    Console.WriteLine("Hasta Pronto!");
                    break;
                }
            }

        }
    }
}
