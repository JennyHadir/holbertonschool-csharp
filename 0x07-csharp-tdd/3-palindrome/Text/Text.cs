using System;
using System.Text.RegularExpressions;


namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            s = s.ToLower();
            s = Regex.Replace(s, "[`!@#$%^&*()-{},?;.:/!<> ']", "");
            char[] pal = s.ToCharArray();
            Array.Reverse(pal);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != pal[i])
                    return false;
            }
            return true;
        }

    }
}
