public class Solution2265 {

    int ans = 0;

    public (int, int) Helper(TreeNode root)
    {
        if (root == null)
        {
            return (0, 0);
        }
        
        var (leftsum, leftcount) = Helper(root.left);
        var (rightsum, rightcount) = Helper(root.right);

        int currSum = root.val + leftsum + rightsum;
        int currCount = 1 + leftcount + rightcount;
        if (currSum / currCount == root.val)
        {
            ans++;
        }
        return (currSum, currCount);
    }
    public int AverageOfSubtree(TreeNode root) {
        
        Helper(root);

        return ans;
    }
}
