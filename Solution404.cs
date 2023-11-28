public class Solution {
    int ans = 0;
    public void Dfs(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        Dfs(root.left);
        
        if(root.left != null && root.left.left == null && root.left.right == null)
        {
            ans += root.left.val;
        }
        Dfs(root.right);

    }
    public int SumOfLeftLeaves(TreeNode root) {
        
        Dfs(root);
        return ans;
    }
}
