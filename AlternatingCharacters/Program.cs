using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            buscar();
        }


        private static void buscar()
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Se está leyendo el fichero");
            int counter = 0;
            string line;
            string s = string.Empty;
           System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\nvalle\Desktop\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                 s =s+line;
                counter++;
            }
            file.Close();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Se terminó de leer fichero");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Cantidad de caracteres del fichero:  " + s.Count());

            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Procesando información");
            int result = alternatingCharacters(s);
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("Enter para realizar de nuevo");
            Console.ReadLine();
            buscar();

        }

        private static int alternatingCharacters(string s)
        {

            var date = DateTime.Now.TimeOfDay;
            var salida = 0;
            var valorActual =Convert.ToChar(" ");
            var valorSiguiente = Convert.ToChar(" ");
            var cantidad = s.Count()-2;

            for (int i = 0; i < s.Count()-1; i++)
            {
                var date0 = DateTime.Now.TimeOfDay;
                valorActual = s[i];
                valorSiguiente = s[i+1];
                if (valorActual == valorSiguiente)
                {
                    salida++;
                }

               

                


                Console.SetCursorPosition(0, 6);
                Console.WriteLine("Iteración Actual:   " + Convert.ToString(i));

                Console.SetCursorPosition(0, 7);
                Console.WriteLine("Iteraciones Restantes:    " + Convert.ToString(Convert.ToInt32(cantidad - i)));

                Console.SetCursorPosition(0, 9);
                Console.WriteLine("Carácteres encontrados:    " + salida);



                var date2 = DateTime.Now.TimeOfDay;

                var date10 = (TimeSpan)date2 - date;

                var date3 = (TimeSpan)date2 - date0;

                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Tiempo iteración Milisegundos:    " + date3.Milliseconds.ToString());

                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Tiempo Total segundos:    " + date10.TotalSeconds.ToString());

                Console.SetCursorPosition(0, 11);
                Console.WriteLine("Iteraciones por Segundo (Aproximado) :    " + Convert.ToString((i + 1) / date10.TotalSeconds));


            }

            var date4 = DateTime.Now.TimeOfDay;

            var date5 = (TimeSpan)date4 - date;
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Tiempo Total segundos:    "+ date5.TotalSeconds.ToString());

            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Iteraciones por Segundo (Aproximado) :    " + Convert.ToString(((cantidad + 1) / date5.TotalSeconds )));

            return salida;
        }
    }
}
