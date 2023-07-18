using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int H = Convert.ToInt32(Console.ReadLine())%12;
            int angle = 360 / 12;

            Console.WriteLine(Math.Min(H*angle,360- H * angle));
            Console.ReadKey();

        }
    }
}
