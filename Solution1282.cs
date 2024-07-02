public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        Dictionary<int, List<int>> dic = new  Dictionary<int, List<int>>();
        IList<IList<int>> result = new List<IList<int>>();

        for(int i = 0; i < groupSizes.Length; i++ ){
            int j = groupSizes[i];
            if(!dic.ContainsKey(j)){
                dic[j] = new List<int>();
            }
            dic[j].Add(i);
            if(dic[j].Count() == j){
                result.Add(new List<int>(dic[j]));
                dic[j].Clear();
            }
        }
        return result;
    }
    
}
