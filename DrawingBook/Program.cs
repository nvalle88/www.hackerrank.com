using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {

            buscar();
        }


        private static void buscar()
        {

            
            Console.WriteLine("Entre la cadena de caracteres");
            string s = Console.ReadLine();

            Console.WriteLine("Entre el caracter que desea Buscar");
            string caracter = Console.ReadLine().ToString().Substring(0, 1);

            Console.WriteLine("Entre hasta la posición que desea buscar");
            long n = Convert.ToInt64(Console.ReadLine());

            var result = repeatedString(s, n, caracter);

            Console.WriteLine("Cantidad de caracteres encontrados: " + result.ToString());

            Console.Write("Enter para Realizar de Nuevo");
            Console.ReadLine();
            buscar();

        }

        private static long repeatedString(string s, long n,string caracter)
        {

            if (s=="a")
            {
                return n;
            }

            var d = Math.Floor( Convert.ToDecimal(n / s.Count()));
            var r = n - (s.Count() * d);
            return  (long)d * s.Count(f => f == char.Parse(caracter)) + s.Substring(0,(int)r).Count(g=>g==char.Parse(caracter));
        }
    }
}
