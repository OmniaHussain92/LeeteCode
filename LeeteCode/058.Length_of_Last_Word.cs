public class Length_of_Last_Word {
    public int LengthOfLastWord(string s) {
        if(s.Length < 2)
            return s.Length;
        
        if(!s.Contains(" "))
            return s.Length;
        
        var words = s.Trim().Split(' ');
        
        return words[words.Length-1].Trim().Length;
    }
}
