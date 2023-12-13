public class Solution993 {
    public bool IsCousins(TreeNode root, int x, int y) {
        
        if(root is null)
        {
            return false;
        }
        
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            int size = q.Count;
            var xBool = false;
            var yBool = false;

            for(int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                if(node.val == x)
                {
                    xBool = true;
                }
                else if(node.val == y)
                {
                    yBool = true;
                }
                else if(node.left!=null && node.right!=null){
                if(node.left.val==x && node.right.val==y) return false;
                if(node.left.val==y && node.right.val==x) return false;
                }

                if(xBool && yBool)
                {
                    return true;
                }

                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
        }
        return false;
    }
}
