using System;

namespace Text
{
    /// <summary> Str Class</summary>
    public class Str
    {
        ///<summary> Find the index of th first unique char in a string.</summary>
        ///<param name="s"> String to loop through.</param>
        ///<return>Index of first unique char.</return>
        public static int UniqueChar(string s)
        {
            int[] StringCount = new int[256];

            for(int i = 0; i < s.Length; i++)
            {
                StringCount[s[i]] = StringCount[s[i]] + 1;
            }
            for(int i = 0; i < s.Length; i++)
            {
			    if(StringCount[s[i]]==1)
                {
				    return i;
			    }
            }
            return -1;
        }
    }
}