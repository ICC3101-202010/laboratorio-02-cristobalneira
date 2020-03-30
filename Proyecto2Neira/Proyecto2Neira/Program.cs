using System;

namespace Proyecto2Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Espotifai e1 = new Espotifai();
            Cancion c1 = new Cancion("c", "c", "c", "c");
            Console.WriteLine(c1.Informacion());
            e1.Agregar(c1);
            Console.WriteLine(e1.canciones[0]);
            /*
            Console.WriteLine("¡Bienvenido a Espotifai!)");
            Console.WriteLine("Estas son las canciones: ");
            int x = 0;
            do
            {
                Console.WriteLine("Introdusca: 0 salir, 1 ver canciones, 2 agregar canciones");
                x = Convert.ToInt32(Console.ReadLine());
                if (x != 0 && x != 1 && x != 2)
                {
                    x = 4;
                }
            } while (0 <= x && x >= 1);
            */
        }
    }
}