public class Solution965 {

    List<int> list = new List<int>();

    public bool IsUnivalTree(TreeNode root) {
        
        if (root == null)
        {
            return true;
        }

        if (!list.Contains(root.val))
        {
            list.Add(root.val);
        }

        if (list.Count > 1)
        {
            return false;
        }

        return IsUnivalTree(root.left) && IsUnivalTree(root.right);


    }
}