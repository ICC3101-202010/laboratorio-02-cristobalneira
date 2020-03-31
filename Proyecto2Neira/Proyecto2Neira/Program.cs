using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Espotifai e1 = new Espotifai();
            Console.WriteLine("¡Bienvenido a Espotifai!");
            int x = 1;
            do
            {
                int otrointento = 0;
                Console.WriteLine("");
                Console.WriteLine("Introduzca: 0 Salir del menu, 1 Ver canciones, 2 Agregar canciones, 3 Ver canciones por criterio, 4 Crear playlist, 5 Ver mis playlist");
                x = Convert.ToInt32(Console.ReadLine());
                if (x != 1 && x != 2 && x != 3 && x != 4 && x != 5 && x != 0)
                {
                    Console.WriteLine("Error no esta dentro de 0,1,2,3,4,5");
                    Console.WriteLine("Tienes otro intento, no te preocupes!");
                    Console.WriteLine(("0 para salir, 1 para volver"));
                    otrointento=Convert.ToInt32(Console.ReadLine());
                    if (otrointento == 0)
                    {
                        break;
                    }
                    else
                    {
                        x = 6;
                    }
                }
                
                //Ver canciones
                else if (x == 1)
                {
                    e1.VerCanciones();
                }

                //Agregar nueva cancion
                else if (x == 2)
                {
                    Console.WriteLine("Acontinuacion le pediremos la informacion de su nueva cancion");
                    Console.WriteLine("Si no sabe aprete enter");
                    Console.WriteLine("Nombre:");
                    string nombrenuevo = Console.ReadLine();
                    Console.WriteLine("Album:");
                    string albumnuevo = Console.ReadLine();
                    Console.WriteLine("Artista:");
                    string artistanuevo = Console.ReadLine();
                    Console.WriteLine("Genero:");
                    string generonuevo = Console.ReadLine();
                    Cancion cx = new Cancion(nombrenuevo, albumnuevo, artistanuevo, generonuevo);
                    e1.AgregarCancion(cx);
                }

                //Ver canciones por criterio
                else if (x == 3)
                {
                    Console.WriteLine("Ingrese criterio:'nombre','artista','album','genero' De la cancion");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese valor");
                    string valor = Console.ReadLine();
                    Console.WriteLine("");
                    e1.CancionesPorCriterio(criterio, valor);
                }

                //Crear playlist
                else if (x == 4)
                {
                    Console.WriteLine("Nombre de su Playlist");
                    string nombreplaylist = Console.ReadLine();
                    Console.WriteLine("Ingrese criterio:'nombre','artista','album','genero' De la cancion");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese valor");
                    string valor = Console.ReadLine();
                    Console.WriteLine("La/s cancion/es de esta playlist son: ");
                    e1.GenerarPlaylist(criterio, valor, nombreplaylist);
                }

                //Ver mi playlist
                else if (x==5)
                {
                    Console.WriteLine(e1.VerMisPlaylists());
                }

            } while (1 <= x && x <= 6);
            Console.WriteLine("¡Gracias por preferir Espotifai Premium!");
        }
    }
}