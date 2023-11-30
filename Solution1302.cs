public class Solution {
    
    int sum = 0;
    int depth = 0;

    public int findDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(findDepth(root.left), findDepth(root.right)) + 1;
    }

    public void findLeaf(TreeNode root, int level)
    {
        if(root == null)
        {
            return;
        }

        if(root.left == null && root.right == null && level == depth)
        {
            sum += root.val;
        }
        else
        {
            findLeaf(root.left, level+1);
            findLeaf(root.right, level+1);
        }
        
    }

    public int DeepestLeavesSum(TreeNode root) {
        
        depth = findDepth(root);
        findLeaf(root, 1);

        return sum;
    }
}
