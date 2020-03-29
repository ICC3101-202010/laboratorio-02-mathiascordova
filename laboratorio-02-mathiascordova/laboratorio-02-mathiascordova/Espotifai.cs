using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_02_mathiascordova
{
    class Espotifai
    {
        private List<Cancion> canciones = new List<Cancion>();
        private List<Playlist> playlists = new List<Playlist>();
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
        public bool GenerarPlaylist(string criterio, string valor, string nombre)
        {
            List<Cancion> ordenadas=CancionesPorCriterio(criterio, valor);
            int tamano = playlists.Count();
            int count = 0;
            for (int i = 0; i < tamano; i++)
            {
                if (nombre == playlists[i].NombrePlaylist())
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            if (ordenadas.Count() == 0 && criterio!="Nombre" && criterio != "nombre" && criterio != "artista" && criterio != "Artista" && criterio != "Album" && criterio != "album" && criterio != "genero" && criterio != "Genero")
            {
                return false;
            }
            else if (ordenadas.Count()==0)
            {
                Console.WriteLine("No se encontraron canciones que cumplan este criterio");
                return false;
            }
            else if (count!=0)
            {
                Console.WriteLine("Ya existe una playlist con este nombre!");
                return false;
            }
            else
            {
                playlists.Add(new Playlist(nombre, ordenadas));
                return true;
            }



        }
        public string VerMisPlaylists()
        {
            int tamano = playlists.Count();
            string entrega="";
            if (tamano == 0)
            {
                return "";
            }
            else
            {
                for (int i = 0; i < tamano; i++)
                {
                    string nombre = playlists[i].NombrePlaylist();
                    string datos = "";
                    List<Cancion> canciones = playlists[i].RetornanCanciones();
                    for (int a = 0; a < canciones.Count(); a++)
                    {
                        datos += canciones[a].Informacion() + Environment.NewLine;
                    }
                    entrega += nombre + ":" + Environment.NewLine + datos;
                }
                return entrega;
            }
            
        }
    }
}
