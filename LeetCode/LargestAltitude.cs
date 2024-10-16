using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        // Problem #1732
        public int LargestAltitude(int[] gain)
        {
            int prefix = 0;
            int max = 0;
            foreach(int i in gain)
            {
                prefix += i;
                max = Math.Max(max, prefix);
            }
            return max;
        }
    }
}
