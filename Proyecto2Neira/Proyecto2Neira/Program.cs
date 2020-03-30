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
            Cancion c1 = new Cancion("a", "a", "a", "a");
            Cancion c2 = new Cancion("b", "b", "b", "b");
            Cancion c3 = new Cancion("c", "c", "c", "c");
            Cancion c4 = new Cancion("d", "d", "d", "d");

            Espotifai e1 = new Espotifai();

            Console.WriteLine("¡Bienvenido a Espotifai!)");
            int x = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Introduzca: 0 salir, 1 ver canciones, 2 agregar canciones, 3 ver canciones por criterio");
                x = Convert.ToInt32(Console.ReadLine());
                if (x != 1 && x != 2 && x != 3 )
                {
                    break;
                }
                
                else if (x == 1)
                {
                    e1.VerCanciones();
                }

                else if (x == 2)
                {
                    Console.WriteLine("Introducir nombre (enter), album (enter), artista (enter), genero (enter)");
                    Console.WriteLine("Si no sabe aprete enter");
                    string nombrenuevo=Console.ReadLine();
                    string albumnuevo=Console.ReadLine();
                    string artistanuevo=Console.ReadLine();
                    string generonuevo=Console.ReadLine();
                    Cancion cx = new Cancion(nombrenuevo, albumnuevo, artistanuevo, generonuevo);
                    e1.AgregarCancion(cx);
                }
                else
                {
                    Console.WriteLine("Ingrese criterio:");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese valor");
                    string valor = Console.ReadLine();
                    e1.CancionesPorCriterio(criterio, valor);
                }

            } while (0 <= x && x >= 1);
            Console.WriteLine("¡Gracias por preferir Espotifai Premium!");
        }
    }
}