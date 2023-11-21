public class Solution1008 {
    int index = 0;
    int[] preorder;
    int n;

    public TreeNode Helper(int lower, int upper)
    {
        if(index == n)
        {
            return null;
        }

        int val = preorder[index];

        if(val < lower|| val > upper)
        {
            return null;
        }
        index++;
        TreeNode root = new TreeNode(val);
        root.left = Helper(lower, val);
        root.right = Helper(val, upper);
        return root;
    }
    public TreeNode BstFromPreorder(int[] preorder) {
        this.preorder = preorder;
        n = preorder.Length;
        return Helper(int.MinValue, int.MaxValue);
    }
}
