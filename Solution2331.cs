public class Solution2331 {
    public bool EvaluateTree(TreeNode root) {
        
        if (root == null || root.data == 0)
        {
            return false;
        }

        if (root.data == 1)
        {
            return true;
        }

        if (root.data == 2)
        {
            return EvaluateTree(root.left) || EvaluateTree(root.right);
        }
        if (root.data == 3)
        {
            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }

        EvaluateTree(root.left);
        EvaluateTree(root.right);

        return false;

    }
}