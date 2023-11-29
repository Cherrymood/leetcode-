public class Solution101 {
    bool ans = true;
    public int Path(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = Path(root.left);
        int right = Path(root.right);
        if (Math.Abs(left-right) > 1)
        {
            ans = false;
        }
        return Math.Max(left, right) + 1;
    }

    public bool IsBalanced(TreeNode root) {
         
        Path(root);

        return ans;

    }
}
