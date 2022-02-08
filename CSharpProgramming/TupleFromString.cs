using System;

namespace CSharpProgramming
{
    class TupleFromString
    {
        public (int, int) CreateTupleFromString(string str)
        {
            string[] arr = str.Split(" ");
            int mX = Convert.ToInt16(arr[0]);
            int mY = Convert.ToInt16(arr[1]);
            (int x, int y) points = (mX, mY);
            return points;
        }
    }
}
