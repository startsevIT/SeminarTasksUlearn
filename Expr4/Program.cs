using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Expr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int X, Y;
            do {
                Console.Write("X(Должно быть простым): ");
                X = Convert.ToInt32(Console.ReadLine());
            } while (!IsSimple(X));
            do
            {
                Console.Write("Y(Должно быть простым): ");
                Y = Convert.ToInt32(Console.ReadLine());
            } while (!IsSimple(X));

            Console.WriteLine(NumberCount(N,X,Y));
            Console.ReadKey();
        }

        static int NumberCount(int N,int X, int Y)
        {
            int count = 0;
            for (int i = 1; i < N; i++)
                if (i % X == 0 || i % Y == 0)
                    count++;
            return count;
        }

        static bool IsSimple(int x)
        {
            for (int i = 2; i < x; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
    }
}
