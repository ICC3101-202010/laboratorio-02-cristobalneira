using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Cancion
{
    private string nombre;
    private string album;
    private string artista;
    private string genero;

    public Cancion(string nombre, string album, string artista, string genero)
    {
        this.nombre = nombre;
        this.album = album;
        this.artista = artista;
        this.genero = genero;
    }
    public string GetName()
    {
        return nombre;
    }
    public string GetAlbum()
    {
        return album;
    }
    public string GetArtista()
    {
        return artista;
    }
    public string GetGenero()
    {
        return genero;
    }

    public string Informacion()
    {
        return " Genero: " + genero + ", Artista: " + artista + ", Album: " + album + ", Nombre:" + nombre;
    }

}