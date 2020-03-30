using System;
public class Cancion
{
    private string nombre;
    private string album;
    private string artista;
    private string genero;

    public Cancion(string n, string al, string ar, string g)
    {
        this.nombre = n;
        this.album = al;
        this.artista = ar;
        this.genero = g;
    }
    public string NombreCancion()
    {
        return nombre;
    }
    public string AlbumCancion()
    {
        return album;
    }
    public string ArtistaCancion()
    {
        return artista;
    }
    public string GeneroCancion()
    {
        return genero;
    }

    public String Informacion()
    {
        return " genero: " + genero + ", artista: " + artista + ", album: " + album + ", nombre:" + nombre;
    }

}