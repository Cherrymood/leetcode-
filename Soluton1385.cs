public class Solution1385 {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        
        int ans = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            bool is_flag = false;

            for(int j = 0; j < arr2.Length; j++)
            {
                if(is_flag)
                {
                    break;
                }
                if(Math.Abs(arr1[i] - arr2[j]) <= d)
                {
                    is_flag = true;
                }
            }

            if(!is_flag)
            {
                ans++;
            }
        }
        return ans;
    }
}
