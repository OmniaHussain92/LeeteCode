namespace LeeteCode
{
    public class PalindromeNumber
    {
        /// <summary>
        /// * If x is negative number then it isn't palindrome
        /// * If last digit in x is 0 then it cannot be palindrome 
        /// * Get the 2nd half of x and check if it is equal to 1st half or not
        /// </summary>
        /// <param name="x">the int number to check</param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            int reverse = 0;
            while (x > reverse)
            {
                // get the last digit from x and add to reverse
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }

            return reverse == x || x == reverse / 10;
        }
    }
}
