using DTF.LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTF.LeetCode.Controllers
{
    public class TestController : Controller
    {
        public int GetLength(string code)
        {
            return LeetCodeUtils.lengthOfLongestSubstring(code);
        }
    }
}