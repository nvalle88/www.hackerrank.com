using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesRansomNote
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {

            var inicio = DateTime.Now.TimeOfDay;
            var fin = DateTime.Now.TimeOfDay;
            var salida = DateTime.Now.TimeOfDay;
            var notes = note.GroupBy(x => x)
                        .Select(gr => new {palabra = gr.Key, cantidad = gr.Count()}).ToList();
            var megazines = magazine.GroupBy(x => x).Select(gr => new { caracter = gr.Key, cantidad = gr.Count() }).Where(m=>notes.Any(n=>m.caracter==n.palabra && m.cantidad>=n.cantidad)).ToList();

            if (megazines.Count()< notes.Count())
            {
                Console.WriteLine("No");
                 fin = DateTime.Now.TimeOfDay;
                 salida = fin - inicio;
                Console.WriteLine("Tiempo milisegundos:  " + salida.TotalMilliseconds.ToString() +"     Tiempo segundos:  " + salida.TotalSeconds.ToString());
                return;
            }
            
            Console.WriteLine("Yes");
            fin = DateTime.Now.TimeOfDay;
            salida = fin - inicio;
            Console.WriteLine("Tiempo milisegundos:  " + salida.TotalMilliseconds.ToString() + "     Tiempo segundos:  " + salida.TotalSeconds.ToString());
            return;
            
        }


        private static void Buscar()
        {
            Console.WriteLine("Entre la palabras separadas por espacio");
            var s = string.Empty;
            string line;
            int counter = 0;
            System.IO.StreamReader file =
             new System.IO.StreamReader(@"C:\Users\nvalle\Desktop\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                s = s + line;
                counter++;
            }
            string[] magazine = s.Split(' ');
            file.Close();



            Console.WriteLine("Entre la palabras separadas por espacio");
            s = string.Empty;
            line = string.Empty;
            counter = 0;
            System.IO.StreamReader file1 =
             new System.IO.StreamReader(@"C:\Users\nvalle\Desktop\test1.txt");
            while ((line = file1.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                s = s + line;
                counter++;
            }
            string[] note = s.Split(' ');
            file1.Close();
            checkMagazine(magazine, note);
            
            Console.WriteLine("Enter para realizar de Nuevo");
            Console.ReadLine();
            Buscar();

        }

        static void Main(string[] args)
        {
            Buscar();
        }
    }
}
