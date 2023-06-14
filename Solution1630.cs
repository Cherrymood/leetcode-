public class Solution1630 {
public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) 
    
    {
        var answer = new List<bool>();

        for (int i = 0; i < r.Length; i++)
        {
            var trynums = new List<int>();

            for (int k = l[i]; k <= r[i]; k++)
            {
                trynums.Add(nums[k]);
            }

            trynums.Sort();
            answer.Add(IsArithmetic(trynums));
        }

        return answer;
    }

private bool IsArithmetic(List<int> trynums)
        {

            int d = trynums[1] - trynums[0];
            for (int n = 2; n < trynums.Count; n++)
            {
                if ((trynums[n] - trynums[n-1]) != d)
                {
                    return false;
                }
            }
            return true;
        }
}