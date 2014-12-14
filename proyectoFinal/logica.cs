using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado
{
    class Logica
    {






        public static string[] pal = new string[20];

        public static void MostrarLetrero()
        {
            string[] Letrero = {
                                                                           
           "                                                                                                                                                            \n",
           "                 .8.          8 8888        8     ,o888888o.     8 888888888o.      ,o888888o.           .8.          8 888888888o.          ,o888888o.     \n",
           "                .888.         8 8888        8  . 8888     `88.   8 8888    `88.    8888     `88.        .888.         8 8888    `^888.    . 8888     `88.   \n",
           "               :88888.        8 8888        8 ,8 8888       `8b  8 8888     `88 ,8 8888       `8.      :88888.        8 8888        `88. ,8 8888       `8b  \n",
           "              . `88888.       8 8888        8 88 8888        `8b 8 8888     ,88 88 8888               . `88888.       8 8888         `88 88 8888        `8b \n",
           "             .8. `88888.      8 8888        8 88 8888         88 8 8888.   ,88' 88 8888              .8. `88888.      8 8888          88 88 8888         88 \n",
           "            .8`8. `88888.     8 8888        8 88 8888         88 8 888888888P'  88 8888             .8`8. `88888.     8 8888          88 88 8888         88 \n",
           "           .8' `8. `88888.    8 8888888888888 88 8888        ,8P 8 8888`8b      88 8888            .8' `8. `88888.    8 8888         ,88 88 8888        ,8P \n",
           "          .8'   `8. `88888.   8 8888        8 `8 8888       ,8P  8 8888 `8b.    `8 8888       .8' .8'   `8. `88888.   8 8888        ,88' `8 8888       ,8P  \n",
           "         .888888888. `88888.  8 8888        8  ` 8888     ,88'   8 8888   `8b.     8888     ,88' .888888888. `88888.  8 8888    ,o88P'    ` 8888     ,88'   \n",
           "        .8'       `8. `88888. 8 8888        8     `8888888P'     8 8888     `88.    `8888888P'  .8'       `8. `88888. 8 888888888P'          `8888888P'     \n",
                           };
            for (int i = 0; i < Letrero.Length; i++)
            {
                for (int j = 0; j < Letrero[i].Length; j++)
                {


                    Console.Write(Letrero[i][j]);




                }
                // le da el maximo tamaño a la consola
                Console.WindowWidth = Console.LargestWindowWidth;
                Console.WindowHeight = Console.LargestWindowHeight;
                //   cambia el color del fondo y la letra.
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;

            }

        }
        public static string ObtenerPalabra()
        {

            pal[1] = "hola";
            pal[2] = "ahorcado";
            pal[3] = "habitacion";
            pal[4] = "ideologia";


            Random objeto = new Random();

            int numAle = objeto.Next(1, 4);
            return pal[numAle];
        }
        public static string OcultarPalabra(string palabra)
        {

            string palOculta = "";
            string palAdivinando = "";

            palOculta = palabra;
            int extension = palabra.Length;

            int i = 0;



            Console.WriteLine("");
            Console.WriteLine("  Pista : tiene " + extension + " letras");
            for (i = 0; i <= extension - 1; i++)
            {

                palAdivinando += "*";

            }

            Console.Write("\n" + palAdivinando);
            return palAdivinando;
        }
    }
}
