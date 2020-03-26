using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_02_mathiascordova
{
    public class Espotifai
    {
        List<Cancion> canciones = new List<Cancion>();
        public Espotifai()
        {
        }

        public bool AgregarCancion(Cancion cancion)
        {
            int compare = 0;
            int tamano = canciones.Count();
            string data = cancion.Informacion();
            for (int a = 0; a < tamano; a++)
            {
                if (data == canciones[a].Informacion())
                {
                    compare++;
                }
            }
            if (compare != 0)
            {
                return false;
            }
            else
            {
                canciones.Add(cancion);
                return true;
            }
        }

        public void VerCanciones()
        {
            int tamano = canciones.Count();
            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine(canciones[i].Informacion());

            }
        }

        public List<Cancion> CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> entrega = new List<Cancion>();
            int tamano = canciones.Count();

            if (criterio == "Nombre" || criterio == "nombre")
            {
                for (int i = 0; i < tamano; i++)
                {
                    List<string> crit = canciones[i].Criterios();
                    if (crit[0] == valor)
                    {
                        entrega.Add(canciones[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entrega);
            }
            else if (criterio == "Artista" || criterio == "artista")
            {
                for (int i = 0; i < tamano; i++)
                {
                    List<string> crit = canciones[i].Criterios();
                    if (crit[1] == valor)
                    {
                        entrega.Add(canciones[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entrega);

            }
            else if (criterio == "Genero" || criterio == "genero")
            {
                for (int i = 0; i < tamano; i++)
                {
                    List<string> crit = canciones[i].Criterios();
                    if (crit[2] == valor)
                    {
                        entrega.Add(canciones[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entrega);

            }
            else if (criterio == "Nombre" || criterio == "nombre")
            {
                for (int i = 0; i < tamano; i++)
                {
                    List<string> crit = canciones[i].Criterios();
                    if (crit[3] == valor)
                    {
                        entrega.Add(canciones[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entrega);

            }
            else
            {
                Console.WriteLine("No existe el criterio: " + criterio);
                return entrega;
            }
        }
    }
}
