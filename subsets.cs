public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new List<IList<int>> { new List<int>() };

        foreach(int num in nums){
            int size = result.Count;
            for(int i = 0; i < size; i++){
                List<int> existing = new List<int>(result[i]);
                existing.Add(num);
                result.Add(existing);
            }
        }

        return result;            
    }
}
