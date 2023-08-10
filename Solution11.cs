public class Solution11 {
    public int MaxArea(int[] height) {

        var area = 0;
        var maxArea = 0;
        var left = 0;
        int right = height.Length -1;


       while (left < right)
        {
            if (height[left] > height[right])
            {
                area = height[right] * (right - left);
            }

            if (height[left] < height[right])
            {
                area = height[left] * (right - left);
            }

            if (area > maxArea)
                {
                    maxArea = area;
                }
            
            if (height[left] <= height[right])
            {
                left++;
            }
            else if (height[left] > height[right])
            {
                right--;
            }
        }
        return maxArea;
    }
}