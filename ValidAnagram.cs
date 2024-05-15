public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s1 = s.ToCharArray();  // Convert string s to a character array
        char[] s2 = t.ToCharArray();  // Convert string t to a character array

        Array.Sort(s1);  // Sort the character array s1
        Array.Sort(s2);  // Sort the character array s2

        return new string(s1).Equals(new string(s2));  // Check if the sorted arrays are equal
    }
}