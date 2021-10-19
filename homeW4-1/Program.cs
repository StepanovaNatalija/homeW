using System;

namespace homeW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;

            Console.WriteLine("Check how many days is in Jan, Feb..... For that enter month number (1, 2,.....or 12)");
            i = Console.ReadLine();

            switch (i)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":

                    Console.WriteLine("31 days");
                    break;

                case "4":
                case "6":
                case "9":
                case "11":

                    Console.WriteLine("30 days");
                    break;

                case "2":
                    Console.WriteLine("28 days (or 29 days in a leap year)");
                    break;

                default:
                    Console.WriteLine("Invalid entered value - only numbers 1....12 allowed");
                    break;

            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("This is calculator!");
            Console.WriteLine(" ");
            char k;
            double f, s, result;

            Console.Write("Enter first number: ");
            f = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Enter operator (1 for adding, 2 for substracting, 3 for multiplying, 4 for dividing or 5 to exit): ");
            k = (char)Console.Read();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            switch (k)
            {
                case '1':
                    result = f + s;
                    Console.WriteLine("{0} + {1} = {2}", f, s, result);
                    break;

                case '2':
                    result = f - s;
                    Console.WriteLine("{0} - {1} = {2}", f, s, result);
                    break;

                case '3':
                    result = f * s;
                    Console.WriteLine("{0} * {1} = {2}", f, s, result);
                    break;

                case '4':
                    result = f / s;
                    Console.WriteLine("{0} / {1} = {2}", f, s, result);
                    break;

                case '5':
                    Console.WriteLine("You decided to exit without performing an operation");
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}