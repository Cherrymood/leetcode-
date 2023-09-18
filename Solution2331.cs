public class Solution2331 {
    public bool EvaluateTree(TreeNode root) {
        
        if (root == null || root.val == 0)
        {
            return false;
        }

        if (root.val == 1)
        {
            return true;
        }

        if (root.val == 2)
        {
            return EvaluateTree(root.left) || EvaluateTree(root.right);
        }
        if (root.val == 3)
        {
            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }

        EvaluateTree(root.left);
        EvaluateTree(root.right);

        return false;

    }
}