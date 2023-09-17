public class Solution101 {

    public bool dfs(TreeNode root1, TreeNode root2)
    {
        if (root1 == null || root2 == null)
        {
            return root1==root2;
        }

        return (root1.val == root2.val) && dfs(root1.left, root2.right) 
                && dfs(root2.left, root1.right);

    }
    public bool IsSymmetric(TreeNode root) {
        
        return dfs(root.left, root.right);
    }
}