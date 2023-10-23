public class Solution561 {
    public int ArrayPairSum(int[] nums) {
        
        var answer = 0;
        Array.Sort(nums);


        for (int i = 0; i < nums.Length; i++)
        {
            for (int k = i+1; k < nums.Length; k++)
            {
                answer += Math.Min(nums[i], nums[k]);
            }
        }

        return answer;
    }
}