public class Solution2574 {
    public int[] LeftRigthDifference(int[] nums) {

            int len = nums.Length;
            int[] res = new int[len];

            for (int j = 0; j < len; j++)
            {   

                res[j] = Math.Abs(nums.Take(j).Sum() - nums.Skip(j + 1).Sum());
            }
            return res;
    }
}