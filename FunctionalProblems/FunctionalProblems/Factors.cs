using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblems
{
    public class Factors
    {
        public static void PrimeFactor()
        {
            Console.WriteLine(" Enter The Number");

            int num;
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors of given Number");

            if (num >=2)
            {
                for (int i = 2; i < num; i++)
                {
                    while (num % i == 0)
                    {
                        Console.WriteLine("{0} ", i);
                        num = num / i;

                    }
                }
            }
        }

    }
}
