public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int currentArea = 0;
        int l = 0, r = heights.Length - 1;
        while (l < r)
        {
            int lowestPoint = Math.Min(heights[l], heights[r]);
            currentArea = lowestPoint * (r - l);
            maxArea = Math.Max(maxArea, currentArea);
            if (lowestPoint == heights[l])
            {
                l++;
            }
            else if (lowestPoint == heights[r])
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        return maxArea;
    }
}
