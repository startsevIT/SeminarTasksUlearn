using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr7
{
    internal class Program
    {
        struct Vector
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public Vector(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public double Lenght() =>
                Math.Pow(X * X + Y * Y + Z * Z, 0.5);
            public override string ToString() =>
                string.Format("{0},{1},{2}", X, Y, Z);
            public static Vector operator *(Vector v1, Vector v2) =>
                new Vector(v1.Y * v2.Z - v1.Z * v2.Y,
                    v1.Z * v2.X - v1.X * v2.Z,
                    v1.X * v2.Y - v1.Y * v2.X);
        }
        //Направляющий вектор - параллельный
        //Нормальный вектор - перпендикулярный
        static void Main(string[] args)
        {
            Console.WriteLine("A1x+B1y+C1z+D1=0\nA2x+B2y+C2z+D2=0");
            Vector vector1 = CreatePlaneVector(1);
            Vector vector2 = CreatePlaneVector(2);
            Console.WriteLine("Параллельный вектор(направляющий): " +  vector1*vector2);
            Console.WriteLine("Перпендикулярный вектор(нормальный): " + vector1);
        }

        static Vector CreatePlaneVector(int num)
        {
            string[] param = { "A" + num, "B" + num, "C" + num };
            int[] paramCount = { 0, 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(param[i] + ": ");
                paramCount[i] = Convert.ToInt32(Console.ReadLine());
            }
            return new Vector(paramCount[0], paramCount[1], paramCount[2]);
        }
    }
}
