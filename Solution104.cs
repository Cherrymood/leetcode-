public class Tree104 {
    public int val;
    public Tree104 left;
    public Tree104 right;
    public Tree104(int val) {
        this.val = val;
        this.left = left;
        this.right = right;     }
}

public class Solution104 {
    public int MaxDepth(Tree104 root) {

        if (root == null)
        {
            return 0;
        }

        var leftmax = MaxDepth(root.left);
        var rightmax = MaxDepth(root.right);

        return 1+ Math.Max(leftmax, rightmax);
        
    }
}