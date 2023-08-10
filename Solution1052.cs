public class Solution1052 {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {

        int ret = 0;
        int max = 0;
        int sum = 0;

        for (int i = 0; i < customers.Length; i++)
        {
            if (grumpy[i] == 0)
            {
                ret += customers[i];
                customers[i] = 0;
            }
        }

        for(int right = 0, left = 0; right < customers.Length; right++)
        {
            sum += customers[right];

            while(right - left + 1 > minutes)
            {
                sum -= customers[left++];
            }

            max = Math.Max(max, sum);
        }

        return ret + max;

    }
}