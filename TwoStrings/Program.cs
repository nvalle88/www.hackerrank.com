using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    class Program
    {
        static string twoStrings(string s1, string s2)
        {

           var s11 = s1.Distinct().ToArray();
           var s22 = s2.Distinct().ToArray();

            var camtidadS1 = s11.Count();
            var camtidadS2 = s22.Count();
            var cantidadExiste = 0;

            var masCorto = string.Empty;
            var masLargo = string.Empty;

            if (camtidadS1 >= camtidadS2)
            {
                masCorto = string.Join("", s22);
                masLargo = string.Join("", s11);
            }
            else
            {
                masLargo = string.Join("", s22);
                masCorto = string.Join("", s11);
            }

            
            foreach (var item in masCorto)
            {
                if (masLargo.Contains(item))
                {
                    
                        return "YES";
                    
                }
            }
           
            return "NO";
        }
        static void Main(string[] args)
        {

           

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }
            Console.ReadLine();
            
        }
    }
}
