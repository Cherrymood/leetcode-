public class Solution1448 {

    private int answer = 0;

    public int GoodNodes(TreeNode root) {
        
        dfs(root, root.data);

        return answer;
    }
    public void dfs(TreeNode node, int maxVal)
    {
        if (node == null)
        {
            return;
        }

        if (node.data >= maxVal)
            {
                maxVal = node.data;
                answer++;
            }
        dfs(node.left, maxVal);
        dfs(node.right, maxVal);
    }
}