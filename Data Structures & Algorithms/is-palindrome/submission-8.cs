public class Solution {
    public bool IsPalindrome(string s) {
        s = string.Concat(s.Where(char.IsLetterOrDigit)).ToLower();
        char[] arr = s.ToCharArray();
        int l = 0, r = arr.Length - 1;
        while (l < r)
        {
            if (arr[l] != arr[r])
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
