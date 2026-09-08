public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
        for(int i = 0 ; i < nums.Length ; i++){
            int digCount = 0;
            int x = nums[i];
            while(x>0){
                x/=10;
                digCount++;
            }
            if(digCount%2 == 0){
                count++;
            }
        }
        return count;
    }
}