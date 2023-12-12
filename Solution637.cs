public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        var ans = new List<double>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            double levelSum = 0;
            int size = q.Count;

            for(int i = 0; i < size; i++)
            {
                TreeNode node = q.Dequeue();
                levelSum += node.val;

                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            
            ans.Add(levelSum/size);
        }
        return ans;
    }
}
