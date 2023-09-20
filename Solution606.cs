public class Solution606 {
    public string Tree2str(TreeNode root) {
        
        var sB = new StringBuilder();
        dfs(root, sB);
        sB.Remove(0, 1);
        sB.Remove(sB.Length -1, 1);

        return sB.ToString();
    }
    public void dfs(TreeNode root, StringBuilder sB)
    {
        
        if (root != null)
        {
            sB.Append("(");
            sB.Append(root.val);

            if (root.right != null && root.left == null)
            {
                sB.Append("()");
            }

            dfs(root.left, sB);
            dfs(root.right, sB);

            sB.Append(")");
        }

    }

}