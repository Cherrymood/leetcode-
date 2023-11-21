public class Solution {
    Dictionary<int,int> dict = new Dictionary<int,int>();
    public void Inorder(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        Inorder(root.left);

        if (!dict.ContainsKey(root.val))
        {
            dict[root.val] = 1;
        }
        else
        {
            dict[root.val]++;
        }
        Inorder(root.right);
    }
    public int[] FindMode(TreeNode root) {
        
        Inorder(root);
        var res = new List<int>();
        var max = 0;

        foreach(var k in dict.Keys)
        {
            var value = dict[k];
            max = Math.Max(max, value);
        }

        foreach(var k in dict.Keys)
        {
            if(dict[k] == max)
            {
                res.Add(k);
            }
        }

        return res.ToArray();
    }
}
