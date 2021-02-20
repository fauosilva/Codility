using System;

namespace Codility.Iterations
{
    //A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
    //https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    public class BinaryGap
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        public int Solution(int N)
        {
            var binary = BinaryRepresentation(N);
            int longestGap = 0;
            int currentSteak = 0;
            int sequence;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    for (sequence = i + 1; sequence < binary.Length; sequence++)
                    {
                        if (binary[sequence] == '0')
                        {
                            currentSteak++;
                        }
                        else
                        {
                            if (currentSteak > longestGap)
                                longestGap = currentSteak;

                            currentSteak = 0;
                            break;
                        }
                    }
                    i = sequence;
                }

            }

            return longestGap;
        }

        private string BinaryRepresentation(int integer)
        {
            return Convert.ToString(integer, 2);
        }
    }
}
