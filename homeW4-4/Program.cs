using System;

namespace homeW4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
            int[] myArray2 = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                myArray2[i] = myArray1[i];
            }

            Console.Write("This program assignes the same values from one array to another: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("myArray1 is: 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("myArray2 is: " + myArray2[0] + ", " + myArray2[1] + ", " + myArray2[2] + ", " + myArray2[3] + ", " + myArray2[4] + ", " + myArray2[5] + ", " + myArray2[6] + ", " + myArray2[7] + ", " + myArray2[8] + ", " + myArray2[9]);
            Console.WriteLine();
            Console.WriteLine();

            
            
            
            
            string[] e = new string[6];
            string choice, e1, e2, e3, e4, e5, e6;
            int[] n = new int[6];
            int n1, n2, n3, n4, n5, n6;

            Console.Write("Type s for a string array of 6 elements, or n for an array of 6 numbers: ");
            choice = Console.ReadLine();

                     
            switch (choice)
            {
                case "s":
                    Console.Write("Enter first element: ");
                    e1 = Console.ReadLine();
                    Console.Write("Enter second element: ");
                    e2 = Console.ReadLine();
                    Console.Write("Enter third element: ");
                    e3 = Console.ReadLine();
                    Console.Write("Enter fourth element: ");
                    e4 = Console.ReadLine();
                    Console.Write("Enter firth element: ");
                    e5 = Console.ReadLine();
                    Console.Write("Enter sixth element: ");
                    e6 = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(string.Join(", ", e));
                    for (int l = 0; l < 6; l++)
                    {
                        int count1 = 0;
                        
                        for (int q = 0; q < 6; q++)
                        {
                            if (e[l] == e[q])
                            { 
                                count1 = count1 + 1;
                               
                            } 
                        }
                    }
                    if (count1 >= 1)
                        {
                        Console.Write(" Duplicate: " + e[l] + "  " + count1 + "   times");
                        }
                    
                    Console.WriteLine("No duplicate elements in your array!");
                    break;
                case "n":
                    Console.Write("Enter first number: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    n2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter third number: ");
                    n3 = int.Parse(Console.ReadLine());
                    Console.Write("Enter fourth number: ");
                    n4 = int.Parse(Console.ReadLine());
                    Console.Write("Enter firth number: ");
                    n5 = int.Parse(Console.ReadLine());
                    Console.Write("Enter sixth number: ");
                    n6 = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("[{0}]", string.Join(", ", n));
                    for (int k=0; k<6; k++)
                    {
                        int count2 = 0;
                        for (int j=0; j<6; j++)
                        {
                            if (n[j] == n[k])
                            {   count2 = count2 + 1;
                                Console.WriteLine("Duplicate: " + n[j] + "  " + count2 + "   times");
                            } else
                                Console.WriteLine("No duplicate numbers in your array!");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entered value - only s or n was required");
                    break;

            }


            
        }
    }
}
