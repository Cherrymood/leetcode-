public class Solution643 {
    public double FindMaxAverage(int[] nums, int k) {

    int sum = 0;

    for (int idx = 0; idx < k; idx++){
        sum += nums[idx];
    }

    double maxAvg = (double) sum / k;

    for (int idx = k; idx < nums.Length; idx++){
        sum += (nums[idx] - nums[idx - k]);
        maxAvg = Math.Max(maxAvg, (double) sum / k);
    }

    return maxAvg;

    }
}
