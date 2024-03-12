public class Solution2389 {

    public int BS(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length -1;

        while(left <= right)
        {
            int mid = left + (right - left)/ 2;

            if(arr[mid] == target)
            {
                return mid;
            }

            else if(arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid -1;
            }
        }
        return left -1;
    }

    public int[] AnswerQueries(int[] nums, int[] queries) {
        
        Array.Sort(nums);

        int nLen = nums.Length;
        int qLen = queries.Length;
        var ans = new int[qLen];

        if(nLen > 0) Array.Sort(nums);

        for(int i = 1; i < nLen; i++)
        {
            Console.WriteLine(nums[i]);
            nums[i] += nums[i - 1];
            Console.WriteLine(nums[i]);
        }

        for(int i = 0; i < qLen; i++)
        {
            int q = queries[i];
            int result = BS(nums, q);

            ans[i] = result + 1;
        }
        return ans;
    }
}
