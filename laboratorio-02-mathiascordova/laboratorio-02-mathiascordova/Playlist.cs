using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_02_mathiascordova
{
    public class Playlist
    {
        private string nombre;
        private List<Cancion> playlist = new List<Cancion>();
        public Playlist(string nombre, List<Cancion> canciones)
        {
            this.nombre = nombre;
            this.playlist = canciones;
        }
        public string NombrePlaylist()
        {
            return nombre;
        }
        public void MostrarCanciones()
        {
            int tamano = playlist.Count();
            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine(playlist[i].Informacion());
            }
        }
        public List<Cancion> RetornanCanciones()
        {
            return playlist;
        }
    }
}
