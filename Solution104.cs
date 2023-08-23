public class TreeNode104 {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode104(int val=0, TreeNode left= null, TreeNode right= null) {
        this.val = val;
        this.left = left;
        this.right = right;     }
}

public class Solution104 {
    public int MaxDepth(TreeNode root) {

        if (root == null)
        {
            return 0;
        }

        var leftmax = this.MaxDepth(root.left);
        var rightmax = this.MaxDepth(root.right);

        return 1+ Math.Max(leftmax, rightmax);
        
    }
}