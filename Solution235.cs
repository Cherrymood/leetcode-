public class Solution235 {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        if(p.val > root.val && q.val > root.val)
        {
            return LowestCommonAncestor(root.right, p, q);
        }
        else if (p.val < root.val && q.val < root.val)
        {
            return LowestCommonAncestor(root.left, p, q);
        }
        else
        {
            return root;
        }
    }
}
