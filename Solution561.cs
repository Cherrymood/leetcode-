public class Solution561 {
    public int ArrayPairSum(int[] nums) {
        
        var answer = 0;
        Array.Sort(nums);


        for (int i = 0; i < nums.Length - 1; i+=2)
        {
            answer += nums[i];
        }

        return answer;
    }
}