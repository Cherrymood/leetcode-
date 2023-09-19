public class Solution559 {
    
    public int MaxDepth(Node root) {
        
        if (root == null)
        {
            return 0;
        }

        var maxDepth = 0;

        foreach (var child in root.children)
        {
           maxDepth = Math.Max(MaxDepth(child), maxDepth);
        }
        
        return 1 + maxDepth;
    }
}