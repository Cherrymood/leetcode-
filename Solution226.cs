public class Solution226 {

    public void InOrderVals (TreeNode root, List<int> values)
    {
        if (root == null)
        {
            return root;
        }

        InvertTree(root.left);
        InvertTree(root.right);
        (root.left, root.right) = (root.right, root.left);

        return root;

    }
}