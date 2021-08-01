using System;

namespace Text
///<summary> Str Class.</summary>
{
    public class Str
    {
        ///<summary>Find Out how many words are present in a string.</summary>
        ///<param name="s">String to loop throu.</param>
        ///<return> Number of words present.</return>
        public static int CamelCase(string s)
        {
            int count = 0;
            if (s.Length > 0)
            {
                count = 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                    count++;
            }
            return count;

        }
    }
}
