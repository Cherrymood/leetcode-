public class Solution1448 {

    private int answer = 0;

    public int GoodNodes(TreeNode root) {
        
        dfs(root, root.val);

        return answer;
    }
    public void dfs(TreeNode node, int maxVal)
    {
        if (node == null)
        {
            return;
        }

        if (node.val >= maxVal)
            {
                maxVal = node.val;
                answer++;
            }
        dfs(node.left, maxVal);
        dfs(node.right, maxVal);
    }
}