public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        var hs = new HashSet<int>(nums1);
        var ans = new List<int>();

        foreach(var num in nums2)
        {
            if (hs.Contains(num))
            {
                ans.Add(num);
                hs.Remove(num);
            }
        }

        return ans.ToArray();
    }
}
