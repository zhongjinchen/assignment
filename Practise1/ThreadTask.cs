using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practise
{
    class ThreadTask
    {
        public void ThreadTaskCall()
        {
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


            //基于Task的并行
            //for (int i = 0; i < 5; i++)
            //{
            //    Parallel.Invoke(() => {
            //        Console.WriteLine($"A1TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //        Console.WriteLine($"A2TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //    },()=> {
            //        Console.WriteLine($"B1TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //        Console.WriteLine($"B2TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //    });
            //}

            //for/foreach循环方法
            //Parallel.For(0, 10, (x) => {
            //    Console.WriteLine($"{x},TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //    Console.WriteLine(x);
            //    Console.WriteLine(x);

            //});
            //Parallel.ForEach(Enumerable.Range(0,10), (x) => {
            //    Console.WriteLine($"{x},TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //    Console.WriteLine(x);
            //    Console.WriteLine(x);

            //});

            //GetTask();

            //Task.Delay(1);                  //延时
            //Console.WriteLine(Task.FromResult(GetReusltAsync()).Status);      //此方法可以得到一个跑完的Task
            //Console.WriteLine(Task<int>.Factory.StartNew((x)=> { return 3; },2).AsyncState);        //此方法可以获得传入参数
            //Console.WriteLine($"1，外面TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine($"2，外面TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");

            //并行Linq Parallel LINQ 
            //IEnumerable<int> numbers = Enumerable.Range(0, 100);
            //var filter = numbers.AsParallel().Where(w => w % 10 == 0);        //对数据分区，异步运行
            ////filter.ForAll((f) => { Console.WriteLine(f); });        //这个方法也是异步的
            //foreach (var item in filter)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }

        public static async Task GetTask()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"1,TaskId -{ Task.CurrentId},ThreadId -{ Thread.CurrentThread.ManagedThreadId}");
            });
            await Task.Run(() =>
            {
                Console.WriteLine($"2,TaskId -{ Task.CurrentId},ThreadId -{ Thread.CurrentThread.ManagedThreadId}");
            });

            //Task[] tasks =
            //{
            //    Task.Run(()=>Console.WriteLine(1)),
            //    Task.Run(()=>Console.WriteLine(2)),
            //    Task.Run(()=>Console.WriteLine(3)),
            //    Task.Run(()=>Console.WriteLine(4)),

            //};
            //await Task.WhenAll(tasks);
            //Console.WriteLine($"1，GetTask里面TaskId-{Task.CurrentId},ThreadId-{Thread.CurrentThread.ManagedThreadId}");
        }

        public static async Task<int> GetReusltAsync()
        {
            int result = await Task.Run(() =>
            {
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

            await Task.Run(() =>
            {
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
