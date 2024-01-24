public class Solution1823 {
    public int FindTheWinner(int n, int k) {
        
        var q = new Queue<int>();

        for(int i = 1; i <= n; i++)
        {
            q.Enqueue(i);
            Console.WriteLine(i);
        }
        
        int index = 1;

        while(q.Count() != 1)
        {
            var num = q.Dequeue();

            if(index == k)
            {
                index = 1;
                continue;
            }

            q.Enqueue(num);
            index++;
        }

        int ans = q.Peek();
        return ans;
    }
}
