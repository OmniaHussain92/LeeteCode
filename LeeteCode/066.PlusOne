public class Solution {
    public int[] PlusOne(int[] digits) {
        int length = digits.Count()-1;

        for(int i=length; i>=0; i--)
        {
            if(digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i]++;
                return digits;
            }
        }
        
        if(digits[0] > 0)
            return digits;

        // all digits are 9's
        digits =  new int[length+2];
        digits[0] = 1;       
        return digits;
    }
}
