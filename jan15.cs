//LeetCode Daily 01/15/24
public class RandomizedSet {
    HashSet<int> set;
    Random rnd;
    public RandomizedSet() {
        set = new HashSet<int>();
        rnd = new Random();
    }
    
    public bool Insert(int val) {
        return set.Add(val);
    }
    
    public bool Remove(int val) {
        return set.Remove(val);
    }
    
    public int GetRandom() {
        return(set.ElementAt(rnd.Next(0, set.Count)));
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */