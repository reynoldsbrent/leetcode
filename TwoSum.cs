public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> answer = new List<int>();
        for (int i = 0; i < nums.Length; i++){
            for (int j = i + 1; j < nums.Length; j++){
                if (nums[i] + nums[j] == target){
                    answer.Add(i);
                    answer.Add(j);
                }
            }
        }
       int[] twosum =  answer.ToArray();
       return twosum;
    }
}