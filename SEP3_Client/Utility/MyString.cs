using System.Collections.Generic;
using System.Linq;

namespace SEP3_Client.Utility
{
    public class MyString
    {
        public static bool HaveOrInside(string searchWord, string basicWord)
        {
            var searchList = searchWord.ToCharArray().ToList();
            var basicList = basicWord.ToCharArray().ToList();
            var i = 0;
            foreach (var basic in basicList)
            {
                if (searchList[i]==basic)
                {
                    i++;
                    if (searchList.Count<=i)
                    {
                        return true;
                    }
                }
                else
                {
                    i = 0;
                }
            }
            return false;
        }
    }
}