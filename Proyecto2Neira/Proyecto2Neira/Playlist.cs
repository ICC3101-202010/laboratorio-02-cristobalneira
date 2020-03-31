using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Neira
{
    public class Playlist
    {
        private string nombreplaylist;
        private List<Cancion> cancionesplaylist;

        public Playlist(string nombreplaylist)
        {
            cancionesplaylist = new List<Cancion>();
            this.nombreplaylist = nombreplaylist;
        }

        public void AgregarCancionesPlaylist(Cancion cancion)
        {
            cancionesplaylist.Add(cancion);
        }

        public string VerNombrePlaylist()
        {
            return nombreplaylist;
        }

        public void VerCancionesPlaylist()
        {
            int c = 0;
            foreach (Cancion cancion in cancionesplaylist)
            {
                c += 1;
                Console.WriteLine(cancion.Informacion());
            }
            if (c == 0)
            {
                Console.WriteLine("No hay canciones en la playlist");
            }
        }

    }
}
