using System;

namespace FristApp
{
    class program
    {
        struct Circle
        {
            public double x;
            public double y;
            public double r;

        }
        static void Main(string[] args)
        {
            Circle A;
            A.x = Convert.ToDouble(Console.ReadLine());
            A.y = Convert.ToDouble(Console.ReadLine());
            A.r = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine(3.14 * 2 * A.r);

            const double pi = 3.14;
            double r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(pi * r * r);
        }
    }

    struct Triangle
    {
        public int a;
        public int b;
        public int c;
        public int h;

        public double Perimeter()
        {
            double peremeter = (a + b + c);
            return peremeter;
        }
        public double Square()
        {
            int h = (a * b) / c;
            double Square = (a * h) / 2;
            return Square;
        }

    }
    struct square
    {
        public int side;
        public double perimeter()
        {
            double perimeter = 4 * side;
            return perimeter;
        }
        public double Square()
        {
            double square = 2 * side;
            return square;
        }

    }

}



