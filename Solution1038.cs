public class Solution {
    int num = 0;
    public TreeNode BstToGst(TreeNode root) {
        if (root == null)
        {
            return null;
        }

        BstToGst(root.right);
        root.val = root.val + num;
        num = root.val;
        BstToGst(root.left);
        
        return root;
    }
}
