public class Solution563 {
    int ansTilt = 0;

    public int Sum(TreeNode root)
    {
        if(root == null) return 0;

        int left = Sum(root.left);
        int right = Sum(root.right);

        ansTilt += Math.Abs(left - right);

        return root.val + left + right;

    }
    public int FindTilt(TreeNode root) {
        Sum(root);
        
        return ansTilt;
    }
}
