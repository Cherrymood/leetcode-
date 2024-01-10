public class Solution654 {

    public int max(int[] nums, int l, int r)
    {
        int maxI = l;
        for(int i = l; i < r; i++)
        {
            if(nums[maxI] < nums[i])
            {
                maxI = i;
            }
        }
        return maxI;
    }

    public TreeNode ConstructTree(int[] nums, int l, int r)
    {
        if(l == r) return null;

        int maxI = max(nums, l, r);
        TreeNode root = new TreeNode(nums[maxI]);
        root.left = ConstructTree(nums, l, maxI);
        root.right = ConstructTree(nums, maxI+1, r);

        return root;
    }

    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return ConstructTree(nums, 0, nums.Length);
    }
}
