using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ahorcado
{

    public class ahorcado
    {



        public static void Main()
        {

            string palAdivinando = "";
            int extension;
            int i;
            
            Logica.MostrarLetrero();
            
            string palabra = Logica.ObtenerPalabra();
            
            Logica.OcultarPalabra(palabra);

            extension = palabra.Length;

            
            int intento = 0;
            palAdivinando = Logica.OcultarPalabra(palabra);
            
            do
            {

                char lp;
                char le;
                Boolean exito = false;
                Console.Write("\n Escriba una tecla \n");



                lp = Console.ReadLine()[0];
                // bucle que pide al usuario   que introduzca una letra   y va comparando lo que introduce con la palabra guardada
                // y va mostrando las letras acertadas, los intentos que te quedan.
                for (i = 0; i <= extension - 1; i++)
                {

                   
                    le = palabra.Substring(i, 1)[0];

                    if (le.Equals(lp))
                    {
                        StringBuilder sbpal2 = new StringBuilder(palAdivinando);
                        sbpal2[i] = lp;
                        palAdivinando = sbpal2.ToString();

                        exito = true;
                    }
                }
                if (exito)
                {
                    Console.WriteLine("\nBien," + palAdivinando);
                    if (palabra.Equals(palAdivinando))
                    {
                        Console.WriteLine(" Has acertado la palabra {0}", palAdivinando);
                        break;
                    }

                }
                else
                {
                    intento++;

                    Console.WriteLine("\n Esa letra  es  incorrecta, lleva {0} intentos", intento);
                }
                if (intento == 6)
                {
                    Console.Write("perdiste  :(  la palabra era {0}", palabra);
                }
            }
            while (intento <= 5);
            Console.ReadKey();
        }







    }













}

