public class Solution1305 {
    List<int> res = new List<int>();

    public void Dfs(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        Dfs(root.left);
        res.Add(root.val);
        Dfs(root.right);

    }
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        
        Dfs(root1);
        Dfs(root2);

        var ans = res.ToArray();
        Array.Sort(ans);

        return ans.ToList();
    }
}
