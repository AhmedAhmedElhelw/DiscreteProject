using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, sum, start, end;
            Console.WriteLine("Starting Number");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Ending Number");
            end = int.Parse(Console.ReadLine());
            for (num = start; num <= end; num++)
            {
                sum = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum++;
                        break;
                    }
                }

                if (sum == 0 && num != 1)
                    Console.WriteLine("{0} ", num);

            }
            Console.WriteLine("Thanks For Dealing With Us <3 ");
            Console.ReadKey();

        }
    }
}

