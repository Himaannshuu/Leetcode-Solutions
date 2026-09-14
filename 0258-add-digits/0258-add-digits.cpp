class Solution {
public:
    int f(int n){
        int sum = 0;
        int lastDigit = 0;
        while(n > 0){
            lastDigit = n%10;
            n/=10;
            sum+=lastDigit;
        }
        return sum;
    }

    int addDigits(int num) {
        int n = num;
        while(n/10 > 0){
            n = f(n);
        }
        return n;
    }
};