public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char , int> hash = new Dictionary<char , int>();
        hash.Add('I' , 1);
        hash.Add('V' , 5);
        hash.Add('X' , 10);
        hash.Add('L' , 50);
        hash.Add('C' , 100);
        hash.Add('D' , 500);
        hash.Add('M' , 1000);

        int sum = 0;
        int n = s.Length;
        for(int i = 0 ; i < n ; i++){
            if( i != n-1){
                char curr = s[i];
                char next = s[i+1];
                if(hash[curr] >=hash[next]){
                    sum+=hash[curr];
                }
                else{
                    sum+=(hash[next] - hash[curr]);
                    i++;
                }
            }
            else{
                char curr = s[i];
                sum+=hash[curr];
            }
        }
        return sum;
    }
}