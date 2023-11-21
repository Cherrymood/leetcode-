public class Solution270 {

    int num = 0;
    double diff = double.MaxValue;

    public int ClosestValue(TreeNode root, double target) {
        
        if (root == null)
        {
            return 0;
        }
        ClosestValue(root.left, target);

        var diff1 = Math.Abs(root.val - target);
        if(diff > diff1)
        {
            diff = diff1;
            num = root.val;
        }
        ClosestValue(root.right, target);

        return num;
    }
}
