using System;

using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 只读和常量
            //ReadonlyConst readonlyConst = new ReadonlyConst(new Abb());
            //Console.WriteLine(readonlyConst.f);
            //Console.WriteLine(ReadonlyConst.b);
            #endregion

            #region IO和文件操作
            //----路径(Path)
            string path = "c:\\17bang";
            //path = path + @"\test";
            string subPath = Path.Combine(path, @"test.txt");
            string joinPath = Path.Join(path, "try.txt");
            //Console.WriteLine(subPath);

            //Console.WriteLine(Path.HasExtension(subPath));
            //Console.WriteLine(Path.GetExtension(subPath));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(subPath));
            //Console.WriteLine(Path.ChangeExtension(subPath,"cs"));

            //Console.WriteLine(Path.GetDirectoryName(subPath));
            //Console.WriteLine(Path.GetFullPath(subPath));
            //Console.WriteLine(Path.GetPathRoot(subPath));

            //----文件夹(directory)
            //创建
            //Directory.CreateDirectory(Path.Join(path, "fg"));
            //Directory.CreateDirectory(subPath);
            //Directory.CreateDirectory(Path.Join(path, "xl"));
            //Console.WriteLine((0.0/0.0)==double.NaN);

            //查找
            //IEnumerable<string> directorys = Directory.EnumerateDirectories(path,"*x?");
            //foreach (var item in directorys)
            //{
            //    Console.WriteLine(item);
            //}
            //var ds = from d in directorys
            //         where d.EndsWith("g")
            //         select d;
            //IList<string> ls = ds.ToList();

            //Console.WriteLine(Directory.GetCreationTimeUtc(subPath));
            //Console.WriteLine(Directory.GetCurrentDirectory());

            //设置当前目录为
            //Directory.SetCurrentDirectory(subPath);
            //Console.WriteLine(Directory.GetCurrentDirectory());

            //删除   
            //Directory.Delete(path,true);    

            //----文件
            //创建
            string greet = "Hello luckystack";
            StreamWriter writer = File.CreateText(Path.Join(subPath, "greet"));
            //writer.Write(greet);
            //writer.Write(true);

            //添加
            //StreamWriter writer = File.AppendText(Path.Join(subPath, "greet"));
            //writer.WriteLine("fg");

            //冲入
            //writer.Flush = true;     //writer.AutoFlush = true;   //自动冲入

            //销毁dispose/using
            writer.Dispose();

            //using (StreamWriter writer = File.AppendText(Path.Join(subPath, "greet")))
            //{                
            //    writer.WriteLine(new char[] { 'w','w','y','z','b','y'});
            //}

            //用实例调用
            //FileInfo file = new FileInfo(Path.Join(subPath,"greet"));
            //using(StreamWriter writer = file.AppendText())
            //{
            //    writer.Write("study");
            //} 





            #endregion

            #region Link to XML
            //XElement LuckyStack = new XElement(
            //"LuckStack",
            //new XComment("--注释--"),
            //new XElement("student", "王ba", new XAttribute("score", 10))
            //        );

            //XDocument document = new XDocument(new XDeclaration("3.0", "gjhg", "no"), LuckyStack);
            //LuckyStack.Save(@"C:\17bang\fg\xml");
            //Console.WriteLine(document);
            #endregion


            Reflect reflect = new Reflect();
            reflect.reflectCall();

            Console.ReadLine();
        }
    }
}
