public class Solution1325 {
    public TreeNode Delete(TreeNode root, int target)
    {
        if(root == null) return root;

        root.left = Delete(root.left, target);
        root.right = Delete(root.right, target);
        
        if(root.left == null && root.right == null && root.val == target)
        {
            return null;
        }
        else
        {
            return root;
        }
    }
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        
        return Delete(root, target);
    }
}
