public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string currentWord = strs[i];

            char[] sArray = currentWord.ToCharArray();
            Array.Sort(sArray);
            string sortedKey = new string(sArray);

            if (!groups.ContainsKey(sortedKey))
            {
                groups[sortedKey] = new List<string>();
            }
            groups[sortedKey].Add(currentWord);
        }
        return groups.Values.ToList();
    }
}
