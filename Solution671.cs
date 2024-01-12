public class Solution671 {
    int length = 0;
    int index = 0;
    HashSet<int> hs = new HashSet<int>();
    
    public void Nums(TreeNode root)
    { 
        if(root == null) return;

        hs.Add(root.val);

        Nums(root.left);
        Nums(root.right);
    }

    public int FindSecondMinimumValue(TreeNode root) {
       
        Nums(root);
        if(hs.Count() <= 1)
        {
            return -1;
        }

        var nums = new int[hs.Count()];
        foreach(var num in hs)
        {
            nums[index] = num;
            Console.WriteLine(nums[index]);
            index++;
        }

        Array.Sort(nums);
        foreach(var num in nums)
        {
            Console.WriteLine(num);
        }
        return nums[1];


    }
}
