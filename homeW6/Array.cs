using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeW6
{
    public static class Array
    {
        
        public static void Array1ToArray2(int[] array1, int[] array2)
        {
            for (int i  = 0; i < 10; i++)
            {
                array2[i] = array1[i];
            }

            Console.Write("\nElements from your array were assigned to another array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", array2[i]);
            }
            Console.Write("\n");
        }
    } 
}
