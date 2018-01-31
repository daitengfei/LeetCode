using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTF.LeetCode.Common
{
    public class LeetCodeUtils
    {
        public static int lengthOfLongestSubstring(String s)
        {
            int[] m = new int[256];
            m[0] = -1;
            // Arrays.fill(m, -1);
            int res = 0, left = -1;
            for (int i = 0; i < s.Length; ++i)
            {

                left = Math.Max(left, m[s[i]]);
                m[s[i]] = i;
                res = Math.Max(res, i - left);
            }
            return res;
        }

        string convert(string s, int nRows)
        {
            if (nRows <= 1) return s;
            string res = "";
            int size = 2 * nRows - 2;
            for (int i = 0; i < nRows; ++i)
            {
                for (int j = i; j < s.Length; j += size)
                {
                    res += s[j];
                    int tmp = j + size - 2 * i;
                    if (i != 0 && i != nRows - 1 && tmp < s.Length) res += s[tmp];
                }
            }
            return res;
        }
    }
}
