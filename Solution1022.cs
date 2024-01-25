public class Solution1022 {
    public int Helper(TreeNode root, int sum)
    {
        if (root == null) return 0;

        sum = sum*2 + root.val;

        if(root.left == null && root.right == null)
        {
            return sum;
        }
        return Helper(root.left, sum) + Helper(root.right, sum);
    }
    public int SumRootToLeaf(TreeNode root) {
        if(root == null) return 0;
        return Helper(root, 0);
    }
}
