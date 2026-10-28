public class Solution {
    public void Rotate(int[] arr, int k) {
        int n = arr.Length;
        if(n==0) return;
        k = k % n;
        if (k==0) return;
        
        Reverse(arr , 0 , n-1); //Reversing entire array
        Reverse(arr , 0 , k-1); // Reversing first k elements
        Reverse(arr, k , n-1); // Reversing n-k elements

    }

    public void Reverse(int[] arr , int left, int right){
        while(left<right){
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
}