public class Solution1315 {
    public int SumEvenGrandparent(TreeNode root) {
        if (root == null) return 0;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        int ans = 0;

        while(q.Count > 0)
        {
            int size = q.Count;
            var node = q.Dequeue();

                if(node.val % 2 == 0)
                {
                    if(node.left != null) 
                    {
                        if(node.left.left != null)  ans += node.left.left.val;
                        if(node.left.right != null) ans += node.left.right.val;
                    }
                    if(node.right != null) 
                    {
                        if(node.right.left != null)  ans += node.right.left.val;
                        if(node.right.right != null)  ans += node.right.right.val;
                    }
                }
                
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
        }
        return ans;
    }
}
