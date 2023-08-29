public class Solution938 {
        
        public int RangeSumBST(TreeNode root, int low, int high) {
        
        var sum = 0;

        if(root == null)
        {
            return sum;
        }
        
        if (root.val >= low && root.val <= high)
        {
            sum += root.val;

        }

        sum += RangeSumBST(root.left, low, high);
        sum += RangeSumBST(root.right, low, high);



        return sum;
    }
}