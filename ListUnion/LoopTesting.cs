using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUnion
{
    public class LoopTesting
    {
        public static int FindLast (int[] x, int y)
        {
            for (int i = x.Length - 1; i > -1; i--)
            {
                if (x[i] == y)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int LastZero (int[]x)
        {
            for (int i = x.Length - 1; i > -1; i--)
            {
                if (x[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int CountPositive (int[] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int OddOrPos(int[] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (Math.Abs(x[i]%2) == 1 || x[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
