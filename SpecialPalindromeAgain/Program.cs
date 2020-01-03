using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialPalindromeAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Buscar();
        }

        private static void Buscar()
        {

            Console.WriteLine("Entre la cadena");
            string s = Console.ReadLine();

            long result = substrCount(s.Count(), s);
            Console.WriteLine(result.ToString());
            Console.WriteLine("Enter para realizar de nuevo");
            Console.ReadLine();
            Buscar();
        }

        private static long substrCount(int v, string s)
        {
            long retVal = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                var startChar = s[i];
                int diffCharIdx = -1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    var currChar = s[j];
                    if (startChar == currChar)
                    {
                        if ((diffCharIdx == -1) ||
                           (j - diffCharIdx) == (diffCharIdx - i))
                            retVal++;
                    }
                    else
                    {
                        if (diffCharIdx == -1)
                            diffCharIdx = j;
                        else
                            break;
                    }
                }
            }
            return retVal;
        }
    }
}
