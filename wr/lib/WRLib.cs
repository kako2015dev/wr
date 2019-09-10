using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr.lib
{
    public class WRLib
    {
        public string inStr { get; set; }
        public int insideStringWidth { get; internal set; }

        public List< string > Str2List(string s)
        {
            string[] sep = new string[] { " " };
            List<string> res = s.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();
            return res;
        }

        internal List<List<string>> lst2subLists(List<string> lstW)
        {
            throw new NotImplementedException();
        }

        internal string list2str(List<string> subStrList)
        {
            throw new NotImplementedException();
        }

        internal List<string> addStars(List<string> subStrings)
        {
            throw new NotImplementedException();
        }

        internal void drawFirstLastRow()
        {
            throw new NotImplementedException();
        }

        internal void drawMidleRows(List<string> subStringsWithStars)
        {
            throw new NotImplementedException();
        }
    }
}
