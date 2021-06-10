using System;

namespace CodeCoverade.MyFolder
{
    public class Methods
    {
        public static int MultiplyBy1Covered(int number)
        {                                       //line 1 Covered
            int one = 1;                        //line 2 Covered
            return number * one;                //line 3 Covered
        }                                       //line 4 Covered

        public static int MultiplyBy0Uncovered(int number)
        {                                       //line 1 Uncovered
            return number * 0;                  //line 2 Uncovered
        }                                       //line 3 Uncovered

        public static int MultiplyBy5HalfCovered(int number, bool multiplyBy10)
        {

            if (multiplyBy10)
            {
                return number * 5 * 10;
            }
            else
            {
                return number * 5;
            }
        }
    }
}