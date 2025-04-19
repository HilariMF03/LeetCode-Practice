public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; // por si k > n

        Reverse(nums, 0, n - 1);       // Paso 1: invertir todo
        Reverse(nums, 0, k - 1);       // Paso 2: invertir primeros k
        Reverse(nums, k, n - 1);       // Paso 3: invertir el resto
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
