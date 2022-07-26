using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblems
{
    public class HormonicNumber
    {
        public static void HarmonicNumberSeries()
        {
            Console.WriteLine("Enter number ");

            int num;
            num = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (double count = 1; count <= num; count++)
            {
                Console.WriteLine("1/{0} + ", count);
                sum = sum + 1 / count;
            }
            Console.WriteLine("\n The sum of {0} series is {1} ", num, sum);
            Console.ReadLine(); 
        }
    }
}

