using System;
using System.Text.RegularExpressions;


namespace Text
{
    ///<summary>Class Str</summary>
    public class Str
    {
        ///<summary> Check if a string is palindrome or not</summary>
        ///<param name="s"> String to check for</param>
        ///<return>true if palindrome false otherwise</return>
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = Regex.Replace(s, "[:;.,'<>/?!@#$%^&*(){} ]", "");
            char[] pal = s.ToCharArray();
            Array.Reverse(pal);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != pal[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
