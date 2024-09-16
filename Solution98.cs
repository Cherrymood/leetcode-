public class Solution {
    public bool IsValidBST(TreeNode root) {

        return IsValid(root, null, null);

    }
    public bool IsValid(TreeNode root, int? min, int? max) {

        if(root == null) return true;

        var cur = root.val;

        if(cur <= min || cur >= max) return false;
        return IsValid(root.left, min, cur) && IsValid(root.right, cur, max);
    }
}
