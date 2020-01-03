using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            buscar();

        }

        private static void buscar()
        {
            Console.WriteLine("Entre el Arreglr ejemplo: 5 4 3 2 1");

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            Console.WriteLine("Entre Rotacines Izquierda");
            int d = Convert.ToInt32(Console.ReadLine());

            int[] result = rotLeft(a, d);

            Console.WriteLine(String.Join(",", result));
            Console.Write("Enter para Realizar de Nuevo");
            Console.ReadLine();
            buscar();
        }

        private static int[] rotLeft(int[] a, int d)
        {
            int n = a.Count();

            int r = d;
            var finalRotationCount = r % n;
            if (finalRotationCount > 0)
            {
                var temp = new int[n];
                for (int i = 0; i < n - finalRotationCount; i++)
                {
                    temp[i] = a[finalRotationCount + i];
                }

                for (int i = 0; i < finalRotationCount; i++)
                {
                    temp[n - finalRotationCount + i] = a[i];
                }

                a = temp;
            }
            return a;
        }
    }
}
