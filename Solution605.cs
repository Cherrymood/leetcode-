public class Solution605 {
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
            var count = 0;

            for (int i = 0; i < flowerbed.Length-1; i ++)
            {

                if ((flowerbed[0] == 0 && flowerbed[1] == 0) || (flowerbed[ i -1] ==0 && flowerbed[i] == 0 && flowerbed[i-1] ==0) 
                || (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length -2] ==0))
                {
                    flowerbed[i] = 1;
                    count += 1;
                }

            }            
            

        return count >= n;
        
    }
}