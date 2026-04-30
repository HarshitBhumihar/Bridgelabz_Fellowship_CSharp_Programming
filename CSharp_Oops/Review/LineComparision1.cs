using System;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    internal class LineComparision1
    {
        public static double CalculateLength(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static void CompareLines(double length1, double length2)
        {
            if (length1 == length2)
                Console.WriteLine("Both lines are equal.");
            else if (length1 > length2)
                Console.WriteLine("Line 1 is longer than Line 2.");
            else
                Console.WriteLine("Line 2 is longer than Line 1.");
        }
    }
}
