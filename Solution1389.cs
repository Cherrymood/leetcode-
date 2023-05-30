public class Solution1389 {
    public int[] CreateTargetArray(int[] nums, int[] index) 
    {
        int length = nums.Length;
        
        var res = new List<int>();

        for (int i = 0; i < length; i++)
        {
            res.Insert(index[i], nums[i]);
        }
        var target = res.ToArray();   
        return target;
    }
}