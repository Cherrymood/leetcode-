public class Solution1480 {
    public int[] RunningSum(int[] nums) {

        int[] answer = new int[nums.Length];
        int num = 0;

        for (int i=0; i<nums.Length; i++)
        {
            num += nums[i];
            answer[i] = num;
        }
        return answer;
    }
}