using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sock_Merchant
{
    class Program
    {


        static int sockMerchant(int n, int[] ar)
        {

            var salida = ar.GroupBy(ars => ars).Sum(x => x.Count() / 2);
            //var salida = a.Sum(x => x.count);
            
            return salida;
            
        }




        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter("", true);

            int n = 9;

            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = sockMerchant(n, ar);


            n = 10;
            int[] ar1 = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3};
            
            int result1 = sockMerchant(n, ar1);

            Console.WriteLine("Prueba 1:" + result.ToString() + " Pruaba 2:" + result1.ToString());
            Console.ReadLine();

            //
        }
    }
}
