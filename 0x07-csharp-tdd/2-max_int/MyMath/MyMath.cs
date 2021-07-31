using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    ///<summary> Operations Class </summary>
    public class Operations
    {
        ///<summary> Get the max value in the list</summary>
        ///<param name="nums"> List to loop through</param>
        /// <returns> maximum value in the list or 0 if empty</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;
            int max = nums.First();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return (max);
        }
    }
}
