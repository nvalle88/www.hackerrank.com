using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);


        }

        private static int hourglassSum(int[][] arr)
        {


            var max = -63;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    var sum = arr[i + 1][j + 1];
                    for (var k = 0; k < 3; k++)
                    {
                        sum += arr[i][j + k];
                        sum += arr[i + 2][j + k];
                    };
                    if (sum > max) max = sum;
                }
            }

            return max;


        }
    }
}
