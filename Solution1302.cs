public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node(int val) {
        this.val = val;
        this.left = left;
        this.right = right;     }
}
public class Solution {

    int sum = 0;
    int maxDept = 0;

    public int FindDepth(Node current, int level)
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

    public void FindLeaf(Node root, int level)
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
    public int DeepestLeavesSum(Node root) 
    {
        maxDept = FindDepth(root, 0);
        FindLeaf(root, 0);

        return sum;
    }
}