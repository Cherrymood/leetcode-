public class Solution2574 {
    public int[] LeftRigthDifference(int[] nums) {

        if (nums.Length == 0)
        {
            return  new int[]{0};
        }
        
        var answer = new int[nums.Length];

        var leftSum = new int[nums.Length];
        var rightSum = new int[nums.Length];

        var sumLeft = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                leftSum[i] = 0;
            }

            else
            {
                sumLeft += nums[i - 1];
                leftSum[i] = sumLeft;
            }
        }

        var sumRight = nums.Sum();

        for (int k = 0; k < nums.Length; k++)
        {
            if (k == nums.Length - 1)
            {
                rightSum[k] = 0;
            }

            else
            {
                sumRight -= nums[k];
                rightSum[k] = sumRight;
            }
        }

        for (int j = 0; j < nums.Length; j++)
        {
            answer[j] = Math.Abs(leftSum[j] - rightSum[j]);
        }

        return answer;


    }
}