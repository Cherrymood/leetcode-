public class Solution2553 {
    public int[] SeparateDigits(int[] nums) {
        
        List<int> lst = new List<int>();
        
        for(int i = nums.Length - 1; i >= 0;i--){
            while(nums[i] > 0){
                lst.Add(nums[i] % 10);
                nums[i]/=10;
            }
        }
        int[] res = new int[lst.Count];

        for(int i = 0; i < res.Length;i++)
        {
            res[i] = lst[lst.Count - 1 - i];
        }

        return res;
    }
}