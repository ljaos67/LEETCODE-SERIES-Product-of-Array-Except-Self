public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] answer = new int[nums.Length];
        int[] right = new int[nums.Length];
        int[] left = new int[nums.Length];
        left[0] = 1;
        right[nums.Length - 1] = 1;
        // left
        for(int i = 1; i < nums.Length; i++)
        {
            left[i] = nums[i-1] * left[i-1]; 
        }
        // right
        for(int i = nums.Length - 2; i >= 0; i--)
        {
            right[i] = nums[i+1] * right[i+1];
        }
        // Answer
        for(int i = 0; i < nums.Length; i++)
        {
            answer[i] = left[i] * right[i];
        }
        return answer;
    }
}
