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

            
            
            
            
            string choice, e1, e2, e3, e4, e5, e6;
            int n1, n2, n3, n4, n5, n6;

            Console.Write("Enter letter s for a string array of six elements, or n for an array of six numbers: ");
            choice = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            int count1 = 0;
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
                    string[] e = { e1, e2, e3, e4, e5, e6 };
                    Console.WriteLine($"Your array is: {string.Join(" , ", e)}");

                    for (int l = 0; l < e.Length; l++)
                    {
                        for (int q = l + 1; q < e.Length; q++)
                        {
                            if (e[l] == e[q])
                            {
                                Console.WriteLine($"Duplicate element: {e[l]} ");
                                count1 = count1 + 1;
                            }
                        }
                    }

                    if (count1 == 0)
                    {
                        Console.WriteLine("No duplicate elements in your array!");
                    }

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
                    int[] n = { n1, n2, n3, n4, n5, n6 };
                    Console.WriteLine($"Your array is: {string.Join(" , ", n)}");

                    int count2 = 0;

                    for (int k = 0; k < n.Length; k++)
                    {
                        for (int j = k + 1; j < n.Length; j++)
                        {
                            if (n[k] == n[j])
                            {
                                count2 = count2 + 1;
                                Console.WriteLine($"Duplicate element: {n[k]} ");

                            }
                        }
                       
                    }
                    if (count2 == 0)
                    {
                        Console.WriteLine("No duplicate elements in your array!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entered value - only s or n was required");
                    break;
            }     
        }
       
    }
}
