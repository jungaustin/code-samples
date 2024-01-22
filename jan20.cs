//LeetCode Daily 01/20/24
//This problem I could not solve on my own and had to rely on the editorial
class Solution {
    public int SumSubarrayMins(int[] arr) {
        int MOD = 1000000007;
        Stack<int> stack = new Stack<int>();
        long sum = 0;
        for (int i = 0; i <= arr.Length; i++) {
            while ((stack.Count != 0) && (i == arr.Length || arr[stack.Peek()] >= arr[i])) {
                int mid = stack.Pop();
                int left;
                if(stack.Count == 0) {
                    left = mid+1;
                }
                else{
                    left = mid-stack.Peek();
                }
                int right = i-mid;
                long count = left*right % MOD;
                sum += (count*arr[mid])%MOD;
                sum %= MOD;
            }
            stack.Push(i);
        }

        return (int) (sum);
    }
}