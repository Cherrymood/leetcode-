public class Solution872 {
    
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {

    var leaves1 = new List<int>();
    var leaves2 = new List<int>();
    dfs(root1, leaves1);
    dfs(root2, leaves2);
    return leaves1.SequenceEqual(leaves2);
    }
        
    public void dfs(TreeNode node, List<int> leafValues){
        
        if ( node == null)
        { 
            return;
        }

        if (node.left == null && node.right == null)
            {
                leafValues.Add(node.data);
            }
        dfs(node.left, leafValues);
        dfs(node.right, leafValues);
    }
}