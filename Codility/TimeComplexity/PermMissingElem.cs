using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.TimeComplexity
{
    public class PermMissingElem
    {
        //https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
        public int solution(int[] A)
        {
            if(A.Length > 10000)
            {
                long totalSum = 0;
                long expectedSum;
                if ((A.Length + 1) % 2 == 0)
                {
                    expectedSum = Math.BigMul(((A.Length + 1) / 2), A.Length + 2);
                }
                else
                {
                    expectedSum = Math.BigMul(((A.Length + 2) / 2), A.Length + 1);
                }

                for (int i = 0; i < A.Length; i++)
                {
                    totalSum += A[i];
                }

                return Convert.ToInt32(expectedSum - totalSum);
            }
            else
            {
                int totalSum = 0;
                int expectedSum = (A.Length + 1) * (A.Length + 2) / 2;
                for (int i = 0; i < A.Length; i++)
                {
                    totalSum += A[i];
                }

                return expectedSum - totalSum;
            }
        }
    }
}
