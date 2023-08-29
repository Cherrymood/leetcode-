public class Solution1379 {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        
        if (original == null)
        {
            return original;
        }
        if (original == target)
        {
            return cloned;
        }

        return GetTargetCopy(original.left, cloned.left, target) ?? GetTargetCopy(original.right, cloned.right, target);
        
    }
}