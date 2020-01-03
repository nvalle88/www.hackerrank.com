using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nr = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nr[0]);

            long r = Convert.ToInt64(nr[1]);

            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            long ans = CountTriplets(arr, r);

            Console.WriteLine(ans);

            Console.ReadLine();
        }

        private static long CountTriplets(List<long> arr, long r)
        {
            var contador = 0;
            for (int i = 0; i < arr.Count()-1; i++)
                for (int j = i; j < arr.Count()-1; j++)
                {
                    var multiplo = arr[j] * r;
                   
                    if (multiplo == arr[j + 1])
                    contador++;

                }

            var salida = Math.Abs(contador / 3);

            return salida;
        }
    }
}
