public class Solution841 {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var hs = new HashSet<int>();
        hs.Add(0);
        var length = 0;

        for(int i = 0; i < hs.Count; i++)
        {
            length ++;
            foreach(var num in rooms[i])
                {
                    hs.Add(num);
                }
        }

        foreach (var num in hs)
        {
            Console.WriteLine(num);
        }
        return length == rooms.Count;
    }
}