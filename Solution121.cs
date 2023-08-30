public class Solution121 {
    public int MaxProfit(int[] prices) {
        
        var minPrice = int.MaxValue;
        var maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
               minPrice = prices[i];
            }

            var profit = prices[i] - minPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
            profit = 0;
        }

        return maxProfit;

    }
}