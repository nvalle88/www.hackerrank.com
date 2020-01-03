using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonChild
{
    class Program
    {
        static void Main(string[] args)
        {
            Buscar();
        }

        private static void Buscar()
        {
            Console.WriteLine("Entre la cadena 1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Entre la cadena 2");

            string s2 = Console.ReadLine();

            int result = commonChild(s1, s2);
            Console.WriteLine(result.ToString());
            Console.WriteLine("Enter para realizar de nuevo");
            Console.ReadLine();
            Buscar();
        }

        private static int commonChild(string s1, string s2)
        {
            int[,] check = new int[s1.Length + 1, s2.Length + 1];
            var s1Characters = s1.ToCharArray();
            var s2Characters = s2.ToCharArray();


            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1Characters[i] == s2Characters[j])
                    {
                        check[i + 1, j + 1] = check[i, j] + 1;
                    }
                    else
                    {
                        check[i + 1, j + 1] = Math.Max(check[i + 1, j], check[i, j + 1]);
                    }
                }
            }

            return check[s1.Length, s2.Length];
        }
    }
}
