using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {

            Buscar();
        }

        private static void Buscar()
        {
            Console.WriteLine("Entre el primer String");
            string a = Console.ReadLine();
            Console.WriteLine("Entre el segundo String");
            string b = Console.ReadLine();
            int res = makeAnagram(a, b);
            Console.WriteLine(res.ToString());
            Console.WriteLine("Enter Realizar de nuevo");
            Console.ReadLine();
            Buscar();

        }

        private static int makeAnagram(string a, string b)
        {


            var aAuxiliar= a;
            var bAuxiliar = b;
            var cantidad = 0;
            for (int i = 0; i < a.Count(); i++)
            {

                if (bAuxiliar.Contains(a[i]))
                {
                    var valorBuscar = a[i];
                    var AindexBuscar = aAuxiliar.IndexOf(valorBuscar);
                    var BindexBuscar = bAuxiliar.IndexOf(valorBuscar);
                    aAuxiliar = aAuxiliar.Remove(AindexBuscar, 1);
                    bAuxiliar = bAuxiliar.Remove(BindexBuscar, 1);
                    
                }
            }

            cantidad = aAuxiliar.Count() + bAuxiliar.Count();

            return cantidad;


        }
    }
}
