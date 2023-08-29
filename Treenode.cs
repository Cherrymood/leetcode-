public class TreeNode
    {

        public int data;
        public TreeNode left, right;
        public TreeNode (int data)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

    public TreeNode insertLevelOrder(int[] arr, int i)
    {
        TreeNode root = null;

        if (i < arr.Length)
        {
            root = new TreeNode(arr[i]);

            root.left = insertLevelOrder(arr, 2*i+1);

            root.right = insertLevelOrder(arr, 2*i+1);
        }
        return root;
    }


}
