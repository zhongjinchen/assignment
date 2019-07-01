using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace assignment
{
    class EmailRemoveRepeat
    {
        public static void removeRepeat(string path)
        {
            SaveInGroup(Filter(GetFromTxt(path)));

        }
        public static void test()
        {
            /*
            * LC@163.com; lc163.com =>
            * wp@qq.com    ; wp@qq.com =>
            * 
            * */

            SaveInGroup(Filter(new List<string>() { "LC@163.com; lc163.com" }));
            //SaveInGroup(Filter(new List<string>() { "wp@qq.com    ; wp@qq.com" }));

        }

        static IEnumerable<string> GetFromTxt(string path)
        {

            IEnumerable<string> emailFile = File.ReadLines(path);
            return emailFile;

        }


        static IEnumerable<string> Filter(IEnumerable<string> emailFile)
        {
            IList<string> emails = new List<string>();

            foreach (var item in emailFile)
            {

                string[] email = item.Split(";");
                foreach (var i in email)
                {
                    emails.Add(i);

                }
            }
            return emails;
        }

        static void SaveInGroup(IEnumerable<string> emails)
        {

            int x = 0;
            string groupEmails = null;
            var cleanEmails = emails.Distinct();
            foreach (var item in cleanEmails)
            {
                //if (x == 0)
                //{
                //    groupEmails = item;

                //}
                //else if (x % 30 == 0)
                //{

                //    groupEmails = groupEmails + Environment.NewLine + Environment.NewLine;
                //}
                //else
                //{
                //    groupEmails = groupEmails + item+"; ";

                //}
                if (x % 30 == 0 && x != 0)
                {
                    groupEmails = groupEmails + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    groupEmails = groupEmails + item + "; ";

                }
                x++;
            }

            using (StreamWriter writer = File.AppendText(@"C:\17bang\yzHomework\emailList.txt"))
            {
                writer.Write(groupEmails);
            }

            Console.WriteLine(groupEmails);
        }

    }

}
