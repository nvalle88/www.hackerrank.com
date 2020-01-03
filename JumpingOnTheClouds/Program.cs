using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre el array de enteros(0,1) Ejemplo 0 1 0 0 0 0 1 0");
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine(result.ToString());
            Console.ReadLine();

        }

        private static int jumpingOnClouds(int[] c)
        {
            var saltos = 0;
            for (int i = 0; i < c.Count(); i += 0)
            {
                if ((i + 2) < c.Count())
                {
                    if (c[i + 1] == 0 && c[i + 2] == 0 && c[i] == 0)
                    {
                        i = i + 2;
                        saltos++;
                        continue;
                    }
                }

                if ((i + 1) < c.Count())
                {
                    if (c[i + 1] == 0)
                    {
                        i++;
                        saltos++;
                        continue;
                    }
                }

                i++;
            }
            return saltos;
        }
    }
}
