//LeetCode Daily 01/21/24
public class Solution {
    public int Rob(int[] nums) {
        int prev = 0;
        int sum = 0;
        int newSum = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i]+prev > sum) newSum = nums[i] + prev;
            else newSum = sum;
            prev = sum;
            sum = newSum;
        }
        return sum;

    }
}