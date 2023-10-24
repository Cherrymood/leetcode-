public class Solution1979 {
    public int FindGCD(int[] nums) {

        Array.Sort(nums);
        int answer = nums[0];

        while (answer > 0)
        {
            if (nums[0]%answer == 0 && nums[nums.Length-1]%answer == 0)
            {
                break;
            }
            answer--;
        }
        return answer;
    }
}