public class Solution199 {

    List<int> ans = new List<int>();

    public IList<int> RightSideView(TreeNode root) {
        
        Helper(root, 0);

        return ans;
    }

    void Helper(TreeNode root, int level)
    {
        if(root == null)
        {
            return;
        }

        if(ans.Count == level)
        {
            ans.Add(root.val);
        }

        Helper(root.right, level+1);
        Helper(root.left, level+1);

    }
}
