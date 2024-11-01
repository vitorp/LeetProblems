namespace LeetCode;
partial class Solution
{
    // Problem CanJump #55
    public bool CanJump(int[] nums)
    {
        int maxJump = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i <= maxJump)
            {
                maxJump = Math.Max(maxJump, i + nums[i]);
            }
            if (maxJump >= nums.Length - 1)
            {
                return true;
            }
        }
        return false;
    }
}
