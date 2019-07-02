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
            SaveInGroup(Filter(signCastEmpyt(GetFromTxt(path))));
        }

        public static void test()
        {

            /*
            * LC@163.com; lc@163.com =>
            * wp@qq.com    ; wp@qq.com =>
            *  lc@163.com; ,'lc@163.com =>
            *   lc@163.com;    ;:xl@163.com =>
            * */

            //SaveInGroup(Filter(signCastEmpyt(new List<string>() { "LC@163.com; lc@163.com" })));
            //SaveInGroup(Filter(signCastEmpyt(new List<string>() { "wp@qq.com    ; wp@qq.com" })));
            //SaveInGroup(Filter(signCastEmpyt(new List<string>() { "lc@163.com; ,'lc@163.com" })));
            SaveInGroup(Filter(signCastEmpyt(new List<string>() { "  lc@163.com;    ;:xl@163.com" })));

        }

        static IEnumerable<string> GetFromTxt(string path)
        {

            IEnumerable<string> emailFile = File.ReadLines(path);
            return emailFile;

        }
        static IEnumerable<string> signCastEmpyt(IEnumerable<string> emailFile)
        {
            IList<string> emails = new List<string>();
            string[] signs = {"`","\\","'",",","~","!", "#", "$", "%", "^", "&", "*", "_",
                "-", "+", "=", ":", "\"", "<", ">", "(", ")", "|", "?", "{", "}", "[", "]", "/",";"};
            string emailstring=null;
            foreach (var item in emailFile)
            {
                for (int i = 0; i < signs.Length; i++)
                {
                    if (i==0)
                    {
                        emailstring = item.Replace(signs[i], " ");
                    }
                    else
                    {
                        emailstring = emailstring.Replace(signs[i], " ");
                    }

                }
                emails.Add(emailstring);
            }
            return emails;
        }

        static IEnumerable<string> Filter(IEnumerable<string> emailFile)
        {
            IList<string> emails = new List<string>();
            

            foreach (var item in emailFile)
            {
              

                string[] email = item.Split(" ");
                foreach (var i in email)
                {
                    if (i!="")
                    {
                        emails.Add(i.ToLower());

                    }
                    else
                    {
                        //不添加进去
                    }

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
