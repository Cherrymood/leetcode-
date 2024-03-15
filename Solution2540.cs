public class Solution2540 {
    public int GetCommon(int[] nums1, int[] nums2) {
        
        for(int i = 0; i < nums1.Length; i++)
        {
            for(int j = 0; j < nums2.Length; j++)
            {
                if(nums1[i] == nums2[j])
                {
                    return nums1[i];
                }
                if(nums1[i] < nums2[j])
                {
                    break;
                }
            }
        }
        
        return -1;
    }
}
