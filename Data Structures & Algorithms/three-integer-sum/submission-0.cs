public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int target = 0;
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>();
        for (int i = 0; i < nums.Length - 2; i ++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int l = i + 1, r = nums.Length - 1;
            while (l < r)
            {
                int currentSum = nums[i] + nums[l] + nums[r];
                if (currentSum == target)
                {
                    res.Add(new List<int> {nums[i], nums[l], nums[r]});
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1]) {
                        l++;
                    }
                    while (l < r && nums[r] == nums[r + 1]) {
                        r--;
                    }
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
        }
        return res;
    }
}
