using System;

namespace homeW3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.Write("Enter the number to find its absolute value: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Absolute value : " + GetAbsoluteValue(number));
        }

    static double GetAbsoluteValue(double number)
        {
            if (number < 0)
                number =number * -1;

            return number;
        }

    }
}
