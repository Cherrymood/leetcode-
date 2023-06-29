public class Solution2215 {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {

        var set1 = new HashSet<int>(nums1).Except(nums2);
        var set2 = new HashSet<int>(nums2).Except(nums1);

        return new List<IList<int>>{set1.ToList(), set2.ToList()};
        
    }
}