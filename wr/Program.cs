using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wr
{
    class Program
    {
        static void Main(string[] args)
        {
            // საწყისი მონაცემები [შეიზლებოდა input.txt ფაილიდან წაკითვა]
            string testString = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            // ძირითადი "ენჟინის" შექმნა
            lib.WRLib wr = new lib.WRLib();

            // საწყისი მონაცემების დაფიქსირება კლასისი ეგზემპლიარის wr ერთერთ თვისებაში inStr ში
            wr.inStr = testString;

            // წინადადების დაშლა სიტყვების სიად
            List<string> lstW = wr.Str2List(testString);

            // ერთი ქვესტრიქონის სიგრძე
            wr.insideStringWidth = 60;

            // სიტყვების სიის დაშლა "სიტყვების ქვესიებად" თითველი ქვესიის სიგრძე არ უნდა აღემატებოდეს ქვესტრიქონის სიგრძეს (პრობელების ჩათვლით)
            List<List<string>> ll = wr.lst2subLists(lstW);


            List<string> subStrings = new List<string>();
            foreach (var subStrList in ll)
            {
                string s0 = wr.list2str(subStrList);
                subStrings.Add(s0);
            }

            List<string> subStringsWithStars = wr.addStars(subStrings);

            wr.drawFirstLastRow();
            wr.drawMidleRows(subStringsWithStars);
            wr.drawFirstLastRow();


            Console.ReadKey();


        }

    }
}
