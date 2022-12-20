using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n1, n2;
            double sum = 0;
            Console.WriteLine("ENTER 1ST NUMBER");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER 2ND NUMBER");
            n2 = int.Parse(Console.ReadLine());

            for (x = n1; x <= n2; x++)
            {
                for (int j = 1; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == x)
                {
                    Console.WriteLine(sum);
                }
                sum = 0;
            }
            Console.ReadKey();


        }
    }
}

