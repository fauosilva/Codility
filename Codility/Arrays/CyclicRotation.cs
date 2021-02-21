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
            Console.WriteLine($"Entry Array: {A}");

            if (K == 0 || A == null || A.Length == 0)
                return A;

            int mod = K % A.Length;
            if (mod == 0)
                return A;

            int[] returnArray = new int[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                int modPosition = (i + mod) % A.Length;
                if (modPosition - 1 >= 0)
                    returnArray[i] = A[modPosition - 1];
                else
                    returnArray[i] = A[A.Length -1];
            }

            Console.WriteLine($"Return Array: {A}");
            return returnArray;
        }
    }
}

