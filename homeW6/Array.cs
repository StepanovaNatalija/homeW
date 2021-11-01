using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeW6
{
    public class Array
    {
        public int[] myArray2;

    public Array(int[] array)
        {
            int[] myArray1 = new int[10];
            int[] myArray2 = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                myArray2[i] = myArray1[i];
            }
            myArray2 = array;
        }
    } 
}
