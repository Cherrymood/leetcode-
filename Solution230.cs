public class Solution230 {
    int k;
    int ans = 0;
    public void Dfs(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        Dfs(root.left);
        k--;
        if ( k == 0)
        {
            ans = root.val;
        }
        Dfs(root.right);
    }

    public int KthSmallest(TreeNode root, int k) {
        this.k = k;
        Dfs(root);

        return ans;
    }
}
