using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Arrays
{
    public class CyclicRotation
    {
        public int[] Solution (int[] A, int K)
        {
            //Console.WriteLine($"Entry Array: {A}");

            if (K == 0 || A == null || A.Length == 0)
                return A;

            int mod = K % A.Length;
            if (mod == 0)
                return A;

            int[] returnArray = new int[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                //Rotate K into i position element. Uses mod reset the position after the array lenght.
                var returnArrayPosition = (K + i) % A.Length;
                returnArray[returnArrayPosition] = A[i];
            }

            //Console.WriteLine($"Return Array: {A}");
            return returnArray;
        }
    }
}

