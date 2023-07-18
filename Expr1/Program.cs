using System;

namespace Expr1
{
    internal class Program
    {
        /* Expr1. Как поменять местами значения двух переменных? 
         * Можно ли это сделать без ещё одной временной переменной. 
         * Стоит ли так делать?*/
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            b += a;
            a = b - a;
            b = b - a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
