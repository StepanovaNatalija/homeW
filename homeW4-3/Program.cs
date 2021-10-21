using System;

namespace homeW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 7, 9 };
            int sum = 0;

            foreach (int itemInArray in myArray)
            {
                sum += itemInArray;
            }

            Console.Write("This program calculates the sum of array 1,3,5,7,9: " + sum);
            Console.WriteLine();
            Console.WriteLine();



            int[] evenOddArray = { 1, 3, 5, 7, 9, 10 };
            Console.Write("This program searched array 1,3,5,7,9,10 for even and odd numbers:");
            Console.WriteLine(); 
            foreach (int itemInArray in evenOddArray)
            {
                if (itemInArray % 2 == 0)
                {
                    Console.Write(itemInArray + " is even number");
                    Console.WriteLine();
                }
                       else 
                            Console.Write(itemInArray + " is odd number");
                            Console.WriteLine();
            }
        }
    }
}
