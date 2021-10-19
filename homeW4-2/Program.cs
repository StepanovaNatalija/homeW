using System;

namespace homeW4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.Write("This program calculates an area of a circle. Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("An area of a circle is : " + GetAreaCircle(radius));

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            double sideLength;
            Console.Write("This program calculates an area of a regular square. Enter side leghth: ");
            sideLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("An area of a square is : " + GetAreaSquare(sideLength));
        }

        static double GetAreaCircle(double radius)
        {
            double areaCircle;
            double pi = Math.PI;
            areaCircle = pi * radius * radius;
            return areaCircle;
        }

        static double GetAreaSquare(double sideLength)
        {
            double areaSquare;
            areaSquare = sideLength * sideLength;
            return areaSquare;
        }

    }
}
