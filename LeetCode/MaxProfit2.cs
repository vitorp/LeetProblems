namespace LeetCode;
partial class Solution
{
    // Problem MaxProfit2 #122
    public int MaxProfit2(int[] prices)
    {
        int min = prices[0];
        int totalProfit = 0;

        foreach (int price in prices)
        {
            if (price < min) min = price;
            totalProfit = Math.Max(totalProfit, price - min);
        }
        return totalProfit;
    }
}
