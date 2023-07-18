using System;


namespace Expr6
{
    struct Point
    { 
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point ToPoint(string[] str) =>
            new Point(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]), Convert.ToInt32(str[2]));

    }
    struct Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector(Point p1, Point p2)
        { 
            X=p2.X-p1.X;
            Y=p2.Y-p1.Y;
            Z=p2.Z-p1.Z;
        }
        public Vector(int x, int y, int z)
        {
            X=x;
            Y=y;
            Z=z;
        }
        public double Lenght() => 
            Math.Pow(X * X + Y * Y + Z * Z, 0.5);
        public override string ToString() =>
            string.Format("{0},{1},{2}",X,Y,Z);
        public static Vector operator *(Vector v1, Vector v2) =>
            new Vector(v1.Y * v2.Z - v1.Z * v2.Y, 
                v1.Z * v2.X - v1.X * v2.Z, 
                v1.X * v2.Y - v1.Y * v2.X);     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Точка M(не лежит на прямой): ");
            Point M = Point.ToPoint(Console.ReadLine().Split(' '));
            Console.WriteLine("Точка A(часть прямой): ");
            Point A = Point.ToPoint(Console.ReadLine().Split(' '));
            Console.WriteLine("Точка B(часть прямой): ");
            Point B = Point.ToPoint(Console.ReadLine().Split(' '));
            Vector AB = new Vector(A, B);
            Vector AM = new Vector(A, M);
            Vector AMAB = AM * AB;
            Console.WriteLine("Расстояние от точки до прямой: ");
            Console.WriteLine(AMAB.Lenght()/AB.Lenght());
        }
    }
}
