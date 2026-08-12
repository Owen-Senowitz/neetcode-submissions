public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        return counts.OrderByDescending(kvp => kvp.Value)
                     .Take(k)
                     .Select(kvp => kvp.Key)
                     .ToArray();
    }
}
