namespace LeetCode;
partial class Solution
{
    // Problem MaxProfit #121
    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int maxProfit = 0;

        foreach (int price in prices)
        {
            if (price < min) min = price;
            maxProfit = Math.Max(maxProfit, price - min);
        }
        return maxProfit;
    }
}
