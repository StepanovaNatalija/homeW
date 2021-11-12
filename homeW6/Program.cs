using System;

namespace homeW6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            
            Console.Write("Input ten integers in the array :\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element {0} : ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in your array are: ");
            for (int i = 0; i < 10; i++)
            Console.Write("{0}  ", array1[i]);

            int[] array2 = new int[10];

            Array.Array1ToArray2(array1, array2);


        }        
    }
}
