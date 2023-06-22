public class Solution605 {
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
            var count = 0;

                for (int i = 0; i < flowerbed.Count(); i ++)
            {

                if (flowerbed[i] ==0)
                {
                    var emptyleft = (i == 0) || (flowerbed[i - 1] == 0);
                    var emptyright = (i == flowerbed.Length -1) || (flowerbed[i + 1] == 0);
                    if (emptyleft && emptyright)
                    {
                        flowerbed[i] = 1;
                        count ++;
                    } 
                }

            }              
        
        return count >= n;
        
    }
}