public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complemento = target - nums[i];
            if (map.ContainsKey(complemento)) {
                return new int[] { map[complemento], i };
            }
            map[nums[i]] = i;
        }
        return new int[] { };
    }
}
