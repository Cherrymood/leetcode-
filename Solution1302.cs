public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left= null, TreeNode right= null) {
        this.val = val;
        this.left = left;
        this.right = right;     }
}
public class Solution {

    int sum = 0;
    int maxDept = 0;

    public int FindDepth(TreeNode current, int level)
    {
        int maxDept = level;

        if (current.left != null)
        {
            maxDept = FindDepth(current.left, level +1);
        }

        if (current.right != null)
        {
            maxDept = Math.Max( maxDept, FindDepth(current.right, level +1));
        }

        return maxDept;

    }

    public void FindLeaf(TreeNode root, int level)
    {
        if (root == null)
        {
            return;
        }

        if (root.right == null && root.left == null && level == maxDept)
        {
            sum += root.val;
        }

        FindLeaf(root.left, level +1);
        FindLeaf(root.right, level +1);

    }
    public int DeepestLeavesSum(TreeNode root) 
    {
        maxDept = FindDepth(root, 0);
        FindLeaf(root, 0);

        return sum;
    }
}