using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(LeapCountInRange(a-1,b));
            Console.ReadKey();
        }

        static int LeapCountInRange(int l, int r)
        {
            int countL = LeapCount(l);
            int countR = LeapCount(r);
            return countR - countL;
        }

        static int LeapCount(int year)
        {
            return (year / 4) - (year / 100) +(year / 400);
        }
    }
}
