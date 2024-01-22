//LeetCode daily 01/19/24
public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        //recursion where it returns x + recursive function
        //two scenarios, you take the path or you dont. if you take path, change the height, if not change length
        Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();
        int ans = int.MaxValue;
        for(int i = 0; i < matrix[0].Length; i++) {
            ans = Math.Min(ans, FindMinFallingPathSum(matrix, memo, 0, i));
        }
        return ans;

    }
    public int FindMinFallingPathSum(int[][] matrix, Dictionary<(int, int), int> memo, int row, int col) {
        if(row >= matrix.Length || row < 0 || col >= matrix[0].Length || col < 0) {
            return int.MaxValue;
        }
        if(row == matrix.Length-1 && (col <= matrix[0].Length || col > 0)) {
            return matrix[row][col];
        }
        if(memo.ContainsKey((row, col))) {
            memo.TryGetValue((row, col), out var x);
            return x;
        }
        else {
            memo.Add((row, col), matrix[row][col] + Math.Min(Math.Min(FindMinFallingPathSum(matrix, memo, row+1, col-1), FindMinFallingPathSum(matrix, memo, row+1, col)), FindMinFallingPathSum(matrix, memo, row+1, col +1)));
            memo.TryGetValue((row, col), out var x);
            return x;
        }
    }
}