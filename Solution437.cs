public class Solution437 {
    public int PathSum(TreeNode root, int target) {
        int solve(TreeNode root, long sum, Dictionary<long, int> map)
        {
            if(root == null)
            {
                return 0;
            }

            int res = 0;
            sum += root.val;

            if(map.ContainsKey(sum - target))
            {
                res += map[sum - target];
            }

            if(map.ContainsKey(sum))
            {
                map[sum]++;
            }
            else
            {
                map[sum] = 1;
            }

            res += solve(root.left, sum, new Dictionary<long, int> (map));
            res += solve(root.right, sum, new Dictionary<long, int> (map));

            return res;
        }

        var dict = new Dictionary <long, int> ();

        dict[0] = 1;

        return solve(root, 0, dict);
    }
}
