/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/
public class Solution {

    IList<int> list = new List<int>();

    public IList<int> Postorder(Node root) {
        
        if (root == null) return list;

        foreach (var child in root.children)
        
            Postorder(child);
            list.Add(root.val);
        

        return list;
    } 
}