using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.TimeComplexity
{
    public class TapeEquilibrium
    {
        //[10,11]
        public int solution(int[] A)
        {
            long[] totalSumFwd = new long[A.Length];
            long[] totalSumBwk = new long[A.Length];
            
            totalSumFwd[0] = A[0];
            totalSumBwk[0] = A[A.Length - 1];

            long minDif = int.MaxValue;

            for (int i = 1; i < A.Length; i++)
            {
                totalSumFwd[i] = totalSumFwd[i - 1] + A[i];
                totalSumBwk[i] = totalSumBwk[i - 1] + A[A.Length - i - 1];
            }

            for (int j = 1; j < A.Length; j++)
            {
                var walkOneForward = Math.Abs(totalSumFwd[j] - totalSumBwk[A.Length - j]);
                if (walkOneForward < minDif)
                    minDif = walkOneForward;
            }

            return Convert.ToInt32(minDif);
        }
    }
}
