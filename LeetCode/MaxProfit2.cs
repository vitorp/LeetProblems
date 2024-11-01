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
            if (price - min > 0)
            {
                totalProfit += price - min;
                min = price;
            }
        }
        return totalProfit;
    }
}
