public class Solution1365
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] answer = new int[nums.Length];
        var counter = 0;

        for (int i =0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] > nums[j])
                {
                    counter++;
                }
            }
            answer[i] = counter;
            counter = 0;
        }
        return answer;
    }
}
