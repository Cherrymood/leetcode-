public class FindElements {
    
    TreeNode root;
    public FindElements(TreeNode root) {
        this.root = root;
        root.val = 0;
        Recover(root);
    }

    public void Recover(TreeNode root)
    {   
        if(root == null) return;
        
        if(root.left != null) root.left.val = 2 * root.val +1;
        if(root.right != null) root.right.val = 2 * root.val +2;

        Recover(root.left);
        Recover(root.right);
    }
    bool ans = false;
    public void Dfs(TreeNode root, int target)
    {
        if (root == null) return;

        if(root.val == target)
        {
            ans = true;
        }

        Dfs(root.left, target);
        Dfs(root.right, target);
    }
    
    public bool Find(int target) {
        ans = false;
        
        if(root == null) return false;

        Dfs(root, target);

        return ans;

    }
}
