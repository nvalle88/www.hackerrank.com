using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = sherlockAndAnagrams(s);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }



        static int sherlockAndAnagrams(string s)
        {
            var matches = 0;

            for (int i = 1; i <= s.Length - 1; i++)
            {
                var a = new List<string>();

                for (int j = 0; j <= s.Length - i; j++)
                {
                    a.Add(new string(s.Substring(j, i).OrderBy(c => c).ToArray()));
                }

               var b= a.GroupBy(x => x)
                    .Select(d => 
                            new
                            {
                                d.Key, Count = d.Count()
                            })
                    .ToDictionary(g=>g.Key,g=> g.Count);

                foreach (var v in b.Values)
                {
                    matches += v * (v - 1) / 2;
                }
            }

            return matches;
        }
    }
}
