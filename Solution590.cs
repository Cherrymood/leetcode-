
public class Node1 {
    public int val;
    public IList<Node1> children;

    public Node1() {}

    public Node1(int _val) {
        val = _val;
    }

    public Node1(int _val, IList<Node1> children) {
        val = _val;
        children = children;
    }
}

public class Solution590 {

    IList<int> list = new List<int>();

    public IList<int> Postorder(Node1 root) {
        
        if (root == null) return list;

        foreach (var child in root.children)
        
            Postorder(child);
            list.Add(root.val);
        

        return list;
    } 
}