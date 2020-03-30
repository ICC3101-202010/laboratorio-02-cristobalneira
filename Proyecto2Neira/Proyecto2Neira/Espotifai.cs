using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Espotifai

{
    public List<Cancion> canciones;
    public List<Cancion> cancionesporcriterio;


    //Lista= canciones
    public Espotifai()
    {
        canciones = new List<Cancion>();
        cancionesporcriterio = new List<Cancion>();
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
            else
            {
                Console.WriteLine("Anteriormente se muestran las canciones que se encontraron en el programa");
            }

        }
        return cancionesporcriterio;
    }
}