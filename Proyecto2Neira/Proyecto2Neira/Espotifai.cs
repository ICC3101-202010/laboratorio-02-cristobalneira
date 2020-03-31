using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2Neira;

public class Espotifai

{
    private List<Cancion> canciones;
    private List<Playlist> playlists;

    public Espotifai()
    {
        canciones = new List<Cancion>();
        
        playlists = new List<Playlist>();
    }

    public bool AgregarCancion(Cancion cancionNueva)
    {
        string infoCancion = cancionNueva.Informacion();
        bool existeCancion = false;

        foreach (Cancion cancion in canciones)
        {
            if (cancion.Informacion() == infoCancion)
            {
                existeCancion = true;
            }

        }
        if (existeCancion == false)
        {
            canciones.Add(cancionNueva);
        }
        else
        {
            Console.WriteLine("La cancion de nombre: '" + cancionNueva.GetName() + "' ya existe en la lista de canciones");
        }
        return existeCancion;
    }

    public void VerCanciones()
    {
        int c = 0;
        foreach (Cancion cancion in canciones)
        {
            c += 1;
            Console.WriteLine(cancion.Informacion());
        }
        if (c == 0)
        {
            Console.WriteLine("No hay canciones en el programa");
        }
    }

    public List<Cancion> CancionesPorCriterio(string criterio, string valor)
    {
        List<Cancion> cancionesporcriterio = new List<Cancion>();
        int c = 0;
        foreach (Cancion cancion in canciones)
        {
            string nombrevalor = cancion.GetName();
            string artistavalor = cancion.GetArtista();
            string albumvalor = cancion.GetAlbum();
            string generovalor = cancion.GetGenero();

            if (criterio == "nombre" && nombrevalor == valor)
            {
                cancionesporcriterio.Add(cancion);
            }
            else if (criterio == "artista" && artistavalor == valor)
            {
                cancionesporcriterio.Add(cancion);
            }
            else if (criterio == "genero" && generovalor == valor)
            {
                cancionesporcriterio.Add(cancion);

            }
            else if (criterio == "album" && albumvalor == valor)
            {

                cancionesporcriterio.Add(cancion);
            }
        }
        foreach (Cancion cancion1 in cancionesporcriterio)
            {
                c += 1;
                Console.WriteLine(cancion1.Informacion());
            }
        if (c == 0)
        {
            Console.WriteLine("Error no hay canciones en el programa con ese valor de criterio");
        }
        else if (c!=0)
        {
            Console.WriteLine("Anteriormente se muestran las canciones que se encontraron en el programa");
        }
        
        return cancionesporcriterio;
    }




  
    public bool GenerarPlaylist(string criterio, string valorcriterio, string nombrePlaylist)
    {
        //criterio = nombre, valor= a , nombre = playlist1
        List<Cancion> cancionesporcriterio = new List<Cancion>();
        Playlist playlistnueva = new Playlist(nombrePlaylist);
        bool generar = false;
        bool generarp = true;

        foreach (Playlist nombres in playlists)
        {
            if (nombrePlaylist == nombres.VerNombrePlaylist())
            {
                generarp = false;
                Console.WriteLine("La playlist ya existe");
                break;
            }
        }
        foreach (Cancion cancion in canciones)
        {
            string nombrevalor = cancion.GetName();
            string artistavalor = cancion.GetArtista();
            string albumvalor = cancion.GetAlbum();
            string generovalor = cancion.GetGenero();


            if (criterio == "nombre" && nombrevalor == valorcriterio)
            {
                generar = true;
                playlistnueva.AgregarCancionesPlaylist(cancion);
                cancionesporcriterio.Add(cancion);

            }
            else if (criterio == "artista" && artistavalor == valorcriterio)
            {
                generar = true;
                playlistnueva.AgregarCancionesPlaylist(cancion);
                cancionesporcriterio.Add(cancion);
            }
            else if (criterio == "genero" && generovalor == valorcriterio)
            {
                generar = true;
                playlistnueva.AgregarCancionesPlaylist(cancion);
                cancionesporcriterio.Add(cancion);

            }
            else if (criterio == "album" && albumvalor == valorcriterio)
            {
                generar = true;
                playlistnueva.AgregarCancionesPlaylist(cancion);
                cancionesporcriterio.Add(cancion);
            }
        }

        int c = 0;
        foreach (Cancion cancion1 in cancionesporcriterio)
        {
            c += 1;
            Console.WriteLine(cancion1.Informacion());
        }
        if (c == 0)
        {
            Console.WriteLine("Error no hay canciones en el programa con ese valor de criterio");
        }

        if (generar == true && generarp == true)
        {
            playlists.Add(playlistnueva);
            return true;
        }
        else
        {
            Console.WriteLine("Hubo un problema");
            return false;
        }
    }

    public string VerMisPlaylists()
    {
        int c = 0;
        foreach (Playlist p in playlists)
        {
            c += 1;
            Console.WriteLine("Nombre playlist: ");
            Console.WriteLine(p.VerNombrePlaylist());
            Console.WriteLine("Con sus canciones: ");
            p.VerCancionesPlaylist();
        }
        if (c == 0) { return "No hay playlists";
        }

        else {
            return "Estas son sus playlist con sus canciones respectivas";

        }
        
    }
}