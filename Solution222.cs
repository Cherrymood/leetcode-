public class Solution222 {
    public int CountNodes(TreeNode root) {
        
        if (root == null)
        {
            return 0;
        }

        else
        {
            return 1+ CountNodes(root.left) + CountNodes(root.right);
        }
    }
}