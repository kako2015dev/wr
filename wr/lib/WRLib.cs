using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr.lib
{
    class WRLib
    {
        public string inStr { get; set; }
        public string star { get; set; }
        public int zoma { get; set; }
        public string separ { get; set; }
        /// <summary>
        /// default constructor
        /// </summary>
        public WRLib()
        {
            inStr = @"rame sitkvebi";
            star = "*";
            zoma = 60;
            separ = " ";
        }
        public int insideStringWidth { get; internal set; }

        public List< string > Str2List(string s)
        {
            string[] sep = new string[] { " " };
            List<string> res = s.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();
            return res;
        }

        internal List<List<string>> lst2subLists(List<string> lstW)
        {
            List<List<string>> res = new List<List<string>>();
            List<string> subLineWords = new List<string>();
            string subLine = "";
            foreach (var w in lstW)
            {
                
                if (subLine.Length + w.Length + 1 <= this.zoma)
                {
                    subLine += this.separ + w;
                    subLineWords.Add(w);
                }
                else
                {
                    res.Add(subLineWords);

                    subLineWords = new List<string>();
                    subLine = "";
                    subLine += this.separ + w;
                    subLineWords.Add(w);

                }
            }
            res.Add(subLineWords);
            return res;
            //throw new NotImplementedException();
        }

        internal string list2str(List<string> subStrList)
        {
            string res = "";
            foreach (var w in subStrList)
            {
                res += " " + w;
            }
            return res;
            //throw new NotImplementedException();
        }

        internal string gatanabreba(string word)
        {
            string res = "";
            res = word + this.rep(this.separ, this.zoma - word.Length);

            return res;
            //throw new NotImplementedException();
        }

        internal List<string> subWords2sibStrings(List<List<string>> ll)
        {
            List<string> subStrings = new List<string>();
            foreach (var subStrList in ll)
            {
                string s0 = this.list2str(subStrList);
                subStrings.Add(this.gatanabreba(s0));
            }
            return subStrings;
        }


        internal List<string> addStars(List<string> subStrings)
        {
            List<string> subStringsWithStars = new List<string>();
            foreach (var subStr in subStrings)
            {
                string s;
                s = this.star + subStr + this.star;
                subStringsWithStars.Add(s);
            }
            return subStringsWithStars;

            //throw new NotImplementedException();
        }

        internal void drawFirstLastRow()
        {
            Console.WriteLine(this.FirstLastLine());
        }
        private string FirstLastLine()
        {
            return this.rep(this.star, this.zoma);
        }
        private string rep(string oneChar, int zoma)
        {
            return new string(oneChar[0], zoma);
        }
        internal void drawMidleRows(List<string> subStringsWithStars)
        {
            foreach (var midLine in subStringsWithStars)
            {
                Console.WriteLine(midLine);
            }
            //throw new NotImplementedException();
        }
    }
}
