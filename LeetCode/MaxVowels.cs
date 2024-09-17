using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // Problem #1456
    public partial class Solution
    {
        public int MaxVowels(string s, int k)
        {
            var maxVowels = 0;
            var vowelCount = 0;

            for(int i = 0; i<k; i++)
            {
                if ("aeiou".Contains(s[i])) vowelCount++;
            }
            maxVowels = vowelCount;
            for(int i = k; i < s.Length; i++)
            {
                if ("aeiou".Contains(s[i-k])) vowelCount--;
                if ("aeiou".Contains(s[i])) vowelCount++;
                maxVowels = Math.Max(maxVowels, vowelCount);
            }
            return maxVowels;
        }
    }
}
