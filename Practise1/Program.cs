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

            //Thread current = Thread.CurrentThread;
            //Thread current = new Thread(new ThreadStart(process));
            //work.IsBackground = true;
            //current.Start();
            //Thread.Sleep(3000);
            //Console.WriteLine("111");
            //Console.WriteLine("111");
            //Console.WriteLine("111");

            Action getup = () =>
              {
                  Console.WriteLine($"Action里面的1：Task-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                  Console.WriteLine($"Action里面的2：Task-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                  
              };

            //Func<int,long> func = (x) => {
            //    Console.WriteLine($"Func里面的1：Task-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //    Console.WriteLine($"Func里面的2：Task-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

            //    return DateTime.Now.Ticks;
            //};
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"第{i + 1}次");
            //    //Task t = new Task(getup);
            //    Task<long> t = new Task<long>((x) =>
            //    {
            //        Console.WriteLine($"Func里面的1：Task-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //        Console.WriteLine($"Func里面的2：Task-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

            //        return DateTime.Now.Ticks;
            //    }, 2);
            //    t.Start();

            //    //Console.WriteLine($"外面的：Task-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //    //Console.WriteLine("wwwwwwwwwwwwwwwwwwwwwwww");
            //    //Console.WriteLine("dddddddddddddddddddddddddddddd");
            //    //Console.WriteLine("sssssssssssssssssssssssssss");

            //    //t.RunSynchronously();       //同步运行
            //    //t.Wait();                   //等待这个任务完成
            //    //Task t = Task.Run(getup);
            //    //Task t = Task.Factory.StartNew(getup);
            //    //Console.WriteLine($"t.result={t.Result}");
            //    //Console.WriteLine("呦吼");
            //    //Console.WriteLine();

            //    //继续
            //    //t.ContinueWith((x) => { });
            //}
            //异常处理
            //Task[] getups = new Task[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    getups[i] = Task.Factory.StartNew(x =>  throw new Exception(x.ToString()),i);

            //}
            //try
            //{
            //    Task.WaitAll(getups);
            //}
            //catch (AggregateException ea)
            //{

            //    foreach (var item in ea.InnerExceptions)
            //    {
            //        Console.WriteLine(item.Message);
            //    }
            //另一种方法
            //    //    ea.Handle((x) => {
            //    //        Console.WriteLine(x.Message);
            //    //        return true;
            //    //    });

            //}

            //Task c= Task.Run(()=> {

            //    Thread.Sleep(30);
            //    throw new Exception("异常");
            //});
            //while (!c.IsCompleted)
            //{

            //    Console.WriteLine(c.Status);
            //}
            //Console.WriteLine(c.IsFaulted);

            //if (c.IsFaulted)
            //{
            //    foreach (var item in c.Exception.InnerExceptions)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            ////取消
            //CancellationTokenSource source = new CancellationTokenSource();
            //CancellationToken token = source.Token;
            //Task tokTask = Task.Run(() =>
            //{

            //    Console.WriteLine("取消前");
            //    //token.ThrowIfCancellationRequested();
            //    token.Register(() => {
            //        Console.WriteLine("token.Register");
            //        throw new Exception();
            //    });
            //    Console.WriteLine("取消后");
            //}, token);

            //Thread.Sleep(1);
            //source.Cancel();

            //try
            //{
            //    tokTask.Wait();            //一定要用wait才能捕获到线程上面的异常
            //}
            //catch (AggregateException e)
            //{
            //    throw;
            //}

            //异步方法
            //GetTaskAsync();
            //wrap();
            //Console.WriteLine($"1，外面TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine($"2，外面TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

            //基于Task的并行
            for (int i = 0; i < 5; i++)
            {
                Parallel.Invoke(() => {
                    Console.WriteLine($"A1TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                    Console.WriteLine($"A2TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                },()=> {
                    Console.WriteLine($"B1TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                    Console.WriteLine($"B2TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                });
            }

            //Task.Delay(1);
            //Task.FromResult();

            Console.ReadLine();
        }

        public static async Task<int> GetReusltAsync()
        {
            int result = await Task.Run(()=> {
                Console.WriteLine($"1,result内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"2,result内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

                Console.WriteLine($"3,result内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                return new Random().Next();
            });
            return result;
        }

        public static async Task wrap()
        {
            Task<int> task = GetReusltAsync();
            Console.WriteLine($"1,wrap内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"2,wrap内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            int result = await task;
            Console.WriteLine($"wrap内await之后result-{result},TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

        }


        public static async Task GetTaskAsync()
        {
            Console.WriteLine($"1，async内await前TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"2，async内await前TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

            await Task.Run(() => {
                Console.WriteLine($"1，await内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"2，await内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"3，await内TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

            });
            Console.WriteLine($"1，async内await后TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"2，async内await后TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"3，async内await后TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

        }

        static void process()
        {
            Thread current = Thread.CurrentThread;

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(current.ManagedThreadId);
            Console.WriteLine(current.IsThreadPoolThread);
            Console.WriteLine(current.Priority);
            Console.WriteLine(Thread.GetDomain().FriendlyName);
            Console.WriteLine(current.ThreadState);
        }

    }
}
