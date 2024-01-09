public class Solution257 {
    public void PathFinder(TreeNode root, string str,  IList<string> paths)
    {
        if(root == null) return;

        if(root.left == null && root.right == null)
        {
            str += root.val;
            paths.Add(str);
            return;
        }

        str += root.val + "->";
        PathFinder(root.left, str, paths);
        PathFinder(root.right, str, paths);

    }
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> paths = new List<string>();
        PathFinder(root, "", paths);
        return paths;
    }
}
