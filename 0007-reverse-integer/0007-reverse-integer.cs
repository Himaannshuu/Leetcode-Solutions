public class Solution {
    public int Reverse(int x) {
        long revNum = 0;
        bool isNegative = x < 0 ;
        long  num = x;
        if (isNegative)
        {
            num = -x;
        }
        while (num > 0)
        {
            long lastDigit = num%10;
            num/=10;
            revNum = (revNum*10) + lastDigit;
        }
        
        if(revNum < int.MinValue || revNum > int.MaxValue) return 0;
        else if (isNegative) return (int) -revNum;
        else return (int)revNum;
    }
}