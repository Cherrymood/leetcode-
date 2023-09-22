public class Solution543 {
    
    int  maxDiam = 0;
    public int Maxdepth(TreeNode root)

    {
        if (root == null)
        {
            return 0;
        }

        var left = Maxdepth(root.left);
        var right = Maxdepth(root.right);

        maxDiam = Math.Max(maxDiam, left + right);

        return Math.Max(left, right) + 1;
    }

    public int DiameterOfBinaryTree(TreeNode root) {
         
        Maxdepth(root);
        return maxDiam;

    }
}