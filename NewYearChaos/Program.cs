using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }

        private static void minimumBribes(int[] q)
        {
            int count = 0;

            //always keep track of min three vlaues observed
            //Compare currently seeing value with this three values.
            int midOfThree = int.MaxValue;
            int maxOfThree = int.MaxValue;
            int minOfThree = int.MaxValue;

            //iterating from left to right
            for (int i = q.Length - 1; i >= 0; i--)
            {
                //person has no way to move more than two positions -> wrong
                if ((q[i] - i) > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else
                {
                    //means current value has passed at least 3 values -> wrong
                    if (q[i] > maxOfThree)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                    else if (q[i] > midOfThree)
                    { //means -> current value has bribed 2 ppl
                        count = count + 2;
                    }
                    else if (q[i] > minOfThree)
                    { //means-> current value has bribed 1 person.
                        count = count + 1;
                    }

                    //Now adjust minThree values comparing, taking the current vlaue to account
                    if (q[i] < minOfThree)
                    {
                        maxOfThree = midOfThree;
                        midOfThree = minOfThree;
                        minOfThree = q[i];
                    }
                    else if (q[i] < midOfThree)
                    {
                        maxOfThree = midOfThree;
                        midOfThree = q[i];
                    }
                    else if (q[i] < maxOfThree)
                    {
                        maxOfThree = q[i];
                    }
                }
            }

            Console.WriteLine(count);
        }
    }

       
}
