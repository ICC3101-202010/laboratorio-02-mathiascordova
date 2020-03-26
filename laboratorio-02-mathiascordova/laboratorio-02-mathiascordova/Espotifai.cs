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
    }
}
