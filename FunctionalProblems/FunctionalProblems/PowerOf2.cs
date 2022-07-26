using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblems
{
    public class Power
    {
        public static void PowerOf2()
        {
            Console.WriteLine(" Enter The Number ");

            int N;
           N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < N; i++)

            {
                var power = Math.Pow(2, N);

                if (0 <= N && N < 31)
                {
                    Console.WriteLine(power);
                }
                else
                {
                    Console.WriteLine("Enter number from 1 to 30");
                }
                break;
            }
        }
    }
}
