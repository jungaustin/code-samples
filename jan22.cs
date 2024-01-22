//LeetCode Daily 01/22/24
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        Array.Sort(nums);
        int[] ans = new int[2];
        int prev = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == prev) {
                ans[0] = prev;
                break;
            }
            else prev = nums[i];
        }
        nums = new HashSet<int>(nums).ToArray();
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] != i+1) {
                ans[1] = i+1;
                break;
            }
        }
        if(ans[1] == 0) {
            ans[1] = nums.Length+1;
        }
        return ans;
    }
}