public class Solution1382 {

    public void ListTreeNode (TreeNode root, List<TreeNode> nodes)
    {
        if (root == null)
        {
            return;
        }
        
        ListTreeNode(root.left, nodes);
        nodes.Add(root);
        ListTreeNode(root.right, nodes);
    }

    public TreeNode BuildTree (TreeNode[] arr, int index1, int index2 )
    {
        if(index1 > index2)
        {
            return null;
        }

        var middle = index1 + (index2 - index1)/2;

        var node = arr[middle];
        node.left = BuildTree (arr, index1, middle - 1);
        node.right = BuildTree (arr, middle+1, index2);

        return node;
    }

    public TreeNode BalanceBST(TreeNode root) {

        List<TreeNode> nodes = new List<TreeNode>();
        ListTreeNode(root, nodes);
        var arr = nodes.ToArray();

        foreach(var node in arr)
        {
            node.right = null;
            node.left = null;
        }

        return BuildTree(arr, 0, arr.Length-1);

    }
}
