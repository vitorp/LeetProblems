using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        // Problem #643
        public double FindMaxAverage(int[] nums, int k)
        {
            double maxAvg = 0;
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
                maxAvg = sum/k; 
            }
            for (int i = 1; i < nums.Length - (k - 1); i++)
            {
                sum = sum - nums[i-1] + nums[i + k - 1];
                maxAvg = Math.Max(maxAvg, sum / k);
            }
            return maxAvg;
        }
    }
}
