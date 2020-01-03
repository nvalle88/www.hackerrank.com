using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre el Recorrido ejemplo: UDDDUDUU");
            

            string s = Console.ReadLine();
            int n = s.Count();

            int result = countingValleys(n, s);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        private static int countingValleys(int n, string s)
        {
            var esnegativo = 0;
            var cantidad=0;
            var niveles = 0;
            for (int i = 0; i < n; i++)
            {

                if (s[i]==char.Parse("U"))
                {
                    cantidad++;
                    if (cantidad>0)
                    {
                        esnegativo = 1;
                    }

                }
                if (s[i] == char.Parse("D"))
                {
                    cantidad--;
                    if (cantidad<0)
                    {
                        esnegativo = -1;
                    }

                }

                if (cantidad==0 && esnegativo==-1)
                {
                    esnegativo = 0;
                    niveles++;
                }
            }
           
            return niveles;
        }
    }
}
