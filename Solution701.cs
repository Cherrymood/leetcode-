public class Solution701 {
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        
        if(root == null) 
        {
            return new TreeNode(val);
        }

        if(root.val < val) 
        {
            root.right = InsertIntoBST(root.right, val);
        }
        if(root.val > val)
        {
            root.left = InsertIntoBST(root.left, val);
        }

        return root;
    }
}
