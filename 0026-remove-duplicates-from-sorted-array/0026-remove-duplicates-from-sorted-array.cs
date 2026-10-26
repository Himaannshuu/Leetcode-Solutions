public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if (n<2) return n;
        int unique = 1;
        int i = 0;
        for(int j = 1 ; j < n ; j++){
            if(nums[i] != nums[j]){
                i++;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                unique++;
            }
        }
        return unique;
        
        

    }
}