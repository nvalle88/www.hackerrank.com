using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Buscar();
        }

        private static void Buscar()
        {
            Console.WriteLine("Entre los números separados por espacio");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            countSwaps(a);
            Console.WriteLine("Enter para realizar de nuevo...");
            Console.ReadLine();
            Buscar();
        }

        private static void countSwaps(int[] a)
        {
            //Console.WriteLine("First Element:   "+ a.Min());
            //Console.WriteLine("Last Element:    "+a.Max());

            int t;
            int repeticiones = 0;
            for (int i = 1; i < a.Length; i++)
                for (int b = a.Length - 1; b >= i; b--)
                {
                    if (a[b - 1] > a[b])
                    {
                        repeticiones++;
                        t = a[b - 1];
                        a[b - 1] = a[b];
                        a[b] = t;
                    }
                };

            Console.WriteLine($"Array is sorted in {repeticiones} swaps.");
            Console.WriteLine($"First Element: {a.Min()}");
            Console.WriteLine($"Last Element: {a.Max()}");
        }
    }
}
