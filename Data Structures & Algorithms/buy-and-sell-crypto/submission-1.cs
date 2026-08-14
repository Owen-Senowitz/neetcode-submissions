public class Solution {
    public int MaxProfit(int[] prices) {
        int currentProfit = 0;
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                currentProfit = prices[j] - prices[i];
                maxProfit = Math.Max(maxProfit, currentProfit);
            }
        }
        return maxProfit;
    }
}
