ublic class Solution2689 {
    
    List<string> ans = new List<string>();

    public void Dfs(RopeTreeNode root)
    {
        if(root == null)
        {
            return;
        }

        Dfs(root.left);

        if (root.left == null && root.right == null)
        {
            ans.Add(root.val);
        }
        Dfs(root.right);
    }
    public char GetKthCharacter(RopeTreeNode root, int k) {
        
        Dfs(root);
        
        var result = "";
        
        foreach(var str in ans)
        {
            result += str;
        }

        return result[k-1];

    }
}
