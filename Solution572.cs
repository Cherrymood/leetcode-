public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        
        if (root == null) return false;

        if (isIdentical(root, subRoot)) return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    public bool isIdentical(TreeNode root1, TreeNode root2) {

        if(root1 == null || root2 == null)
        {
            return root1 == null && root2 == null;
        }
        return root1.val == root2.val && isIdentical( root1.left, root2.left) && isIdentical( root1.right, root2.right);
    }
}
