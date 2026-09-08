public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        else if (x%10 == 0 && x !=0) return false;
        //else if(x==0) return true;
        else{
            int revNum = 0;
            int num = x;
            while(num > 0){
                int lastDigit = num%10;
                num/=10;
                revNum = (revNum*10) + lastDigit;
            }

            if(x == revNum) return true;
            else return false;
        }
    }
}