public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1;
        while (l < r)
        {
            int currentSum = numbers[l] + numbers[r];
            if (currentSum == target)
            {
                return new int[] {l + 1,r + 1};
            }
            else if (currentSum < target)
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return new int[] {-1,-1};
    }
}
