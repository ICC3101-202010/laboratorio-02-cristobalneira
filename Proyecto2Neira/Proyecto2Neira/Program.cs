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
            //Ejemplos
            Cancion c1 = new Cancion("a", "a", "a", "a");
            Cancion c2 = new Cancion("b", "b", "b", "b");
            Cancion c3 = new Cancion("c", "c", "c", "c");
            Cancion c4 = new Cancion("d", "d", "d", "d");

            Espotifai e1 = new Espotifai();

            Console.WriteLine("¡Bienvenido a Espotifai!)");
            int x = 0;
            int denuev = 7;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Introduzca: 0 Salir del menu, 1 Ver canciones, 2 Agregar canciones, 3 Ver canciones por criterio, 4 Crear playlist, 5 Ver mis playlist");
                x = Convert.ToInt32(Console.ReadLine());
                if (x != 1 && x != 2 && x != 3 && x != 4 && x != 5 && x != 0)
                {
                    Console.WriteLine("Error no esta dentro de 0,1,2,3,4,5");
                    Console.WriteLine("Tienes otra oportunidad! 0 para salir, 1 para devolver al menu");
                    denuev = Convert.ToInt32(Console.ReadLine());
                    if (denuev == 0)
                    {
                        break;
                    }
                    break;
                }
                else if (x == 0)
                {
                    break;
                }
                //Ver canciones
                else if (x == 1)
                {
                    e1.VerCanciones();
                }

                //Agregar nueva cancion
                else if (x == 2)
                {
                    Console.WriteLine("Introducir nombre (enter), album (enter), artista (enter), genero (enter)");
                    Console.WriteLine("Si no sabe aprete enter");
                    string nombrenuevo = Console.ReadLine();
                    string albumnuevo = Console.ReadLine();
                    string artistanuevo = Console.ReadLine();
                    string generonuevo = Console.ReadLine();
                    Cancion cx = new Cancion(nombrenuevo, albumnuevo, artistanuevo, generonuevo);
                    e1.AgregarCancion(cx);
                }

                //Ver canciones por criterio
                else if (x == 3)
                {
                    Console.WriteLine("Ingrese criterio:");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese valor");
                    string valor = Console.ReadLine();
                    e1.CancionesPorCriterio(criterio, valor);
                }

                //Crear playlist
                else if (x == 4)
                {
                    Console.WriteLine("Nombre de su Playlist");
                    string nombreplaylist = Console.ReadLine();
                    Console.WriteLine("Ingrese criterio:");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese valor");
                    string valor = Console.ReadLine();
                    e1.GenerarPlaylist(criterio, valor, nombreplaylist);
                }

                //Ver mi playlist
                else if (x==5)
                {
                    e1.VerMisPlaylists();
                }

            } while (0 <= x && x <= 5);
            Console.WriteLine("¡Gracias por preferir Espotifai Premium!");
        }
    }
}