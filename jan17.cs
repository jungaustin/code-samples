//LeetCode Daily 1/17/24
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++) {
            if(dict.ContainsKey(arr[i])) {
                dict[arr[i]]++;
            }
            else{
                dict.Add(arr[i], 1);
            }
        }
        foreach(int val in dict.Values) {
            if(dict.Values.Count(x => x == val) > 1) {
                return false;
            }
        }
        return true;
    }
}