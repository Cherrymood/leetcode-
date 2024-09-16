public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        var q = new Queue<TreeNode>();
        var ans = new List<IList<int>>();

        if (root == null) {

            return ans;
        }
        q.Enqueue(root);

        while(q.Count > 0)
        {
            int levelSize = q.Count;  // Количество узлов на текущем уровне
            var lst = new List<int>();  // Лист для значений текущего уровня

            // Обрабатываем все узлы на текущем уровне
            for (int i = 0; i < levelSize; i++) 
    
            {
                var item = q.Dequeue();
                lst.Add(item.val);

                if(item.left != null) q.Enqueue(item.left);
                if(item.right != null) q.Enqueue(item.right);
            }

            ans.Add(lst);

        }

        return ans;
    }
}
