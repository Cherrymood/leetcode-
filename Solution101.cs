public class Solution101 {
    public bool isMirror(TreeNode left, TreeNode right)
    {
        if(left == null && right == null)
        {
            return true;
        }

        if(left == null || right == null)
        {
            return false;
        }

        return (left.val == right.val) && isMirror(left.left, right.right) && isMirror(left.right, right.left);
        
    }
    public bool IsSymmetric(TreeNode root) {
        
        return isMirror(root.left, root.right);
    }
}
