//LeetCode Daily 01/18/24
public class Solution {
    Dictionary<int, int> visited = new Dictionary<int, int>();
    public int ClimbStairs(int n) {
        if(n == 1) {
            return 1;
        }
        else if(n == 0) {
            return 1;
        }
        if(visited.ContainsKey(n)) {
            return visited[n];
        }
        else{
            visited.Add(n, (ClimbStairs(n-1) + ClimbStairs(n-2)));
        }
        return visited[n];
    }
}