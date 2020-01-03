using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndTheValidString
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Buscar();
        }


        private static void Buscar()
        {

            Console.WriteLine("Entre la Cadena!");
            string s = string.Empty;
            string line;
            int counter = 0;
            System.IO.StreamReader file =
             new System.IO.StreamReader(@"C:\Users\nvalle\Desktop\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                s = s + line;
                counter++;
            }
            file.Close();
            Console.WriteLine(isValid(s));
            Console.WriteLine("Enter Realizar de Nuevo");
            Console.ReadLine();
            Buscar();
        }

        private static string isValid(string s)
        {
            if (s.Count() <= 1)
                return "YES";
            var dd = s.Count();
            var z = s.GroupBy(x => x)
                     .Select(gr => new { cantidad = gr.Count() })
                     .GroupBy(y => y.cantidad)
                     .Select(gt => new { elem = gt.Count(), cant = gt.Key })
                     .ToList();

            if (z.Count() > 2)
                return "NO";

            if (z.Count(x => x.elem > 1) > 1)
                return "NO";

            if (z.Count() <= 1 || (z.Where(x => x.cant == 1 && x.elem == 1).Count() == 1))
                return "YES";

            if (z.Count == 2)
            {
                var elemento = z.Where(x => x.elem == 1).FirstOrDefault();
                if (elemento != null)
                {
                    var mayor = z.Max(x => x.cant);
                    var menor = z.Min(x => x.cant);
                    if (mayor == menor || menor + 1 == mayor)
                    {
                        return "YES";
                    }
                }
            }
            return "NO";
        }
    }
}
