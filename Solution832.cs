public class Solution832 {
    public int[][] FlipAndInvertImage(int[][] image) {
        
        foreach (var im in image)
        {
            Array.Reverse(im);

            for (int i = 0; i < im.Length; i++)
            {
                if ( im[i] == 1)
                {
                    im[i] = 0;
                }
                else
                {
                    im[i] = 1;
                }
            }
        }

        return image;

    }
}