public class Solution1161 {
    public int MaxLevelSum(TreeNode root) {
        
        int level = 1;
        int sum = Int32.MinValue;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        int lNodes = 1;

        while(q.Count > 0)
        {
            int size = q.Count;
            int sumOfNodes = 0;

            for(int i = 0; i < size; i++)
            {
                var node = q.Dequeue();

                sumOfNodes += node.val;
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }

            if(sumOfNodes > sum)
            {
                sum = sumOfNodes;
                level =lNodes;
            }
            lNodes++;
        }
        return level;
    }
}