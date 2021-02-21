using System;

namespace Codility.TimeComplexity
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y)
                return 0;

            decimal distanceToCover = Y - X;
            decimal minimumJumps = Math.Ceiling(distanceToCover / D);
            return Convert.ToInt32(minimumJumps);
        }
    }
}
