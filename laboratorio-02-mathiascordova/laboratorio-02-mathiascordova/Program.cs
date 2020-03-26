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
                Console.WriteLine("3. Ver canciones por criterio");
                Console.WriteLine("X. Salir de Espotifai");

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
                if (seleccion == "3")
                {
                    Console.WriteLine("Ingrese el criterio (nombre, artista, album, genero):");
                    string crit = Console.ReadLine();
                    Console.WriteLine("Ingrese su busqueda:");
                    string valor = Console.ReadLine();
                    List<Cancion> filtro = spotify.CancionesPorCriterio(crit, valor);
                    int tamano = filtro.Count();
                    for (int i = 0; i < tamano; i++)
                    {
                        Console.WriteLine(filtro[i].Informacion());
                    }
                }
                else if (seleccion == "X" || seleccion == "x")
                {
                    Console.WriteLine("Hasta Pronto!");
                    break;
                }
            }

        }
    }
}
