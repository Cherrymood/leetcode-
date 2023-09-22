public class Solution897 {
    public void inOrder (TreeNode root, List<int> values)
    {
        if (root == null)
        {
            return;
        }

        inOrder(root.left, values);
        values.Add(root.data);
        inOrder(root.right, values);
    }
    public TreeNode IncreasingBST(TreeNode root) {
        
        var values = new List<int>();
        inOrder(root, values);

        TreeNode answer = new TreeNode(0);
        var current = answer;

        foreach (var v in values)
        {
            current.right = new TreeNode(v);
            current = current.right;
        }

        return answer.right;
    }
}