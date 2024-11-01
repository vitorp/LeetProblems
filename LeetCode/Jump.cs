namespace LeetCode;
partial class Solution
{
    // Problem Jump #45
    public int Jump(int[] nums)
    {
        int[] jumps = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int jumpDistance = i + nums[i];
            if (jumpDistance >= nums.Length) jumpDistance = nums.Length - 1;
            while (jumpDistance > i)
            {
                if (jumps[jumpDistance] > 0)
                {
                    jumps[jumpDistance] = Math.Min(1 + jumps[i], jumps[jumpDistance]);
                }
                else
                {
                    jumps[jumpDistance] = 1 + jumps[i];
                }
                jumpDistance--;
            }
        }
        return jumps[^1];
    }
}
