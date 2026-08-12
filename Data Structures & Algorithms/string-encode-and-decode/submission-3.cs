public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        foreach (string s in strs)
        {
            encoded += s + ",|,";
        }
        Console.Write(encoded);
        return encoded;
    }

    public List<string> Decode(string s) {
        return s.Split(",|,").SkipLast(1).ToList();
   }
}
