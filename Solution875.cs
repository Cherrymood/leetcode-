public class Solution875 {
    public int MinEatingSpeed(int[] piles, int h) {

        int max = piles.Max();
        int min = 1;
        int minValue = max;

        while(min <= max)
        {
            int mid = min + (max - min) / 2;
            int hours = 0;

            foreach(var ban in piles)
            {
                hours += (int)Math.Ceiling((double)ban / (double)mid);
            }
            
            if(hours < 0) break;

            Console.WriteLine(hours);
            
            if (hours <= h) 
            {
                max = mid - 1;
                minValue = Math.Min(minValue, mid);
            }

            else
            {
                min = mid +1;
            }
        }

        return minValue;
    }
}
