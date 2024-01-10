public class Solution1026 {
    
    public int Finder(TreeNode root, int min, int max)
    {
        if(root == null) return max - min;

        min = Math.Min(min, root.val);
        max = Math.Max(max, root.val);

        return Math.Max(Finder(root.left, min, max), Finder(root.right, min, max));
    }

    public int MaxAncestorDiff(TreeNode root) {

        return Finder(root, root.val, root.val);
    }
}
