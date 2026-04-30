using System;

namespace Review
{
    internal class LineComparision2 
    {
        
        private int x1, y1, x2, y2;

        
        public LineComparision2(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

       
        public int Compare(LineComparision2 other)
        {
            double length1 = this.GetLength();
            double length2 = other.GetLength();

            if (length1 == length2)
                return 0;   
            else if (length1 > length2)
                return 1;   
            else
                return -1;  
        }
    }
}