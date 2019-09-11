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
            lib.WRLib wr1 = new lib.WRLib();

            // საწყისი მონაცემების დაფიქსირება კლასისი ეგზემპლიარის wr ერთერთ თვისებაში inStr ში
            wr1.inStr = testString;

            // ერთი ქვესტრიქონის სიგრძე
            wr1.insideStringWidth = 60;

            // წინადადების დაშლა სიტყვების სიად
            List<string> lstW = wr1.Str2List(testString);

            // სიტყვების სიის დაშლა "სიტყვების ქვესიებად" თითველი ქვესიის სიგრძე არ უნდა აღემატებოდეს ქვესტრიქონის სიგრძეს (პრობელების ჩათვლით)
            List<List<string>> ll = wr1.lst2subLists(lstW);

            // სიტყვების გადაბმა ქვესტრინგებად და გათანაბრება
            List<string> subStrings = wr1.subWords2sibStrings(ll);

            // ვარსკვლავების დამატება
            List<string> subStringsWithStars = wr1.addStars(subStrings);

            wr1.drawFirstLastRow();
            wr1.drawMidleRows(subStringsWithStars);
            wr1.drawFirstLastRow();


            Console.ReadKey();


        }

    }
}
