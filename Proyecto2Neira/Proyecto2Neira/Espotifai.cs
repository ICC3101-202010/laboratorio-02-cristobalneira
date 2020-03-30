using System;
using System.Collections.Generic;
using System.Linq;

public class Espotifai

{
    public List<Cancion> canciones;

    public Espotifai()
    {
        canciones = new List<Cancion>();
    }
    public void Agregar(Cancion cancion)
    {
        canciones.Add(cancion);
    }


    /*public bool AgregarCancion(Cancion cancion)
    {
        bool existen = (from c in canciones where cancion.NombreCancion = cancion select c).Any();
        bool existear = (from c in canciones where c.cn = cancion select c).Any();
        bool existeal = (from c in canciones where c.cn = cancion select c).Any();

        if (existen == true && existear == true && existeal == true)
        {
            return false;
        }
        else
        {
            canciones.Add(cancion);
            return true;
        }
        */
    
}