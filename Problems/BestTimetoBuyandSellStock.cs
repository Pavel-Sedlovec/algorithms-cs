namespace Algorithms_CS.Problems
{
    public class BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int minBuy = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] - minBuy > maxProfit)
                    maxProfit = prices[i] - minBuy;

                if (prices[i] < minBuy)
                    minBuy = prices[i];
            }
            return maxProfit;
        }
    }
}
