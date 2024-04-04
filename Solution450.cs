public class Solution450 {
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null)
        {
            return root;
        }

        if(root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }

        else if(root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }

        else
        {
            
            if(root.left == null && root.right == null)
            {
                return null;
            }

            else if(root.left == null)
            {
                return root.right;
            }

            else if(root.right == null)
            {
                return root.left;
            }
            
            else
            {
                var tmp = root.right;
                while(tmp.left != null)
                {
                    tmp = tmp.left;
                }

                root.val = tmp.val;
                root.right = DeleteNode(root.right, tmp.val);
            }
        }

        return root;
    }
}
