public class Solution {
    public bool IsPalindrome(string s) {
        string reverse = "";
        string original = s.ToLower();
        List<char> reverseList = new List<char>();
        char[] arr = original.Where(c => char.IsLetterOrDigit(c)).ToArray();
        original = new string(arr);

        for (int i = original.Length - 1; i >= 0; i--){
            reverseList.Add(original[i]);
            
        }
        reverse = new string(reverseList.ToArray());
        Console.WriteLine(reverse);

        if (String.Equals(original, reverse)){
            return true;
        }
        return false;
    }
}