using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = Convert.ToString(a);
            char[] c = b.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(new string(c));
            Console.ReadKey();
        }
    }
}
