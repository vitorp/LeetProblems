namespace LeetCode;
partial class Solution
{
    // Problem Hindex #274
    public int Hindex(int[] citations)
    {
        int[] count = new int[citations.Length];
        int maxH = 0;

        for (int i = 0; i < citations.Length; i++)
        {
            int current = Math.Min(citations[i] - 1, citations.Length - 1);
            if (current >= 0)
            {
                count[current] += 1;
            }
        }

        int accumulator = 0;
        for (int i = citations.Length - 1; i >= 0; i--)
        {
            int current = count[i];
            accumulator += current;
            if (accumulator >= i + 1)
            {
                return i + 1;
            }
        }
        return 0;
    }
}
