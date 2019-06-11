using System;
using System.Collections.Generic;
using System.Linq;
using assignment._17ban;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 引用类型

            //1，引用类型的类型转换
            Basics basics = new Basics();  //注意！！如果父类对象（basics）指向的
            Child child = new Child();     //是子类实例:new Child() 强制转换（子类转父类）就可以转换成功
                                           //child = (Child)basics;         //子类不可以装父类

            //----as,转换失败返回null
            //child = basics as Child;
            //if (child==null)
            //{
            //    Console.WriteLine("basics 未能转换成功，返回null值");
            //}
            //else
            //{
            //    Console.WriteLine("转换成功");
            //}
            //basics = child;                   //父类可以装子类
            //child.BasicsTry();
            //child.ChildTry(); 

            ////----is,判断是否是某种类型，是返回true.否返回false(子类可以是父类，实现接口类型)
            //basics = child;
            //Console.WriteLine(basics is Basics);
            //Console.WriteLine(basics is Child); 
            #endregion

            #region 属性
            //2，属性
            //getSet get = new getSet();
            //get.Age = 4;
            //Console.WriteLine(get.Age);  
            #endregion

            #region 值类型传递，装箱
            //3，值类型传递是copy
            //int i = 8;
            //int j = i;
            //Console.WriteLine(i);     //--i还有值

            ////装箱（值类型赋值给引用类型（object））和拆箱(引用类型（object）赋值给值类型)
            //int i = 8;
            //object j = i;    //装箱,在堆上开辟一个空间，把i的值赋值一份进去，j保存这个空间的地址
            //Console.WriteLine($"i={i},j={j}");
            //int x = (int)j;     //（int）区别于强制类型转换 
            #endregion

            #region 多态
            //4，
            //Console.WriteLine(typeof(char));
            //多态练习
            //Father father = new Son();    //----父类的实例指向子类的引用
            //father.Fly();
            //father.Run();
            ////Console.WriteLine(father.Bird());
            //Dad dad = new Boy();
            //dad.Eat(); 
            #endregion

            #region 接口
            ////5，接口联系
            //Man man = new Man();
            //man.Lunch();
            //man.Rest();
            //man.Swim(); 

            ////接口作业
            ////用接口实例（不是类的实例）调用“找到最大值”的方法 
            //IseekMaxValue Seek = new BinaryChop();
            //IseekMaxValue Seek = new violenceSeek();

            //显式实现
            //IseekMaxValue Seek = new DisplayImplementation();
            //IseekMinValue Seek = new DisplayImplementation();
            //Seek.seek();
            #endregion

            #region 模拟出入栈
            //6，模拟出入栈
            //Mimicstact imitate = new Mimicstact(5);
            //imitate.Push(new object[] {"xl"});  //调用用params（参数数组）方法既可以传递
            //imitate.Push("is", true);         //一个数组实参如(new int[] { 8 })，也可以传递一组数字如（2，2，4）
            //imitate.pop();
            //imitate.Push(10, 3);
            //imitate.Push(4);
            //imitate.Push(7); 
            #endregion

            #region 字符串位置颠倒方法
            //school("yuanzhan"); 
            #endregion

            #region 日期计算
            //Date date = new Date();
            //date.DateCalculation(); 
            #endregion

            #region 使用object改造数据结构栈
            //8，使用object改造数据结构栈（Stack），并在出栈时获得出栈元素      
            //ObjectHomeWork objectHomeWork = new ObjectHomeWork(new object[] { });
            //objectHomeWork.Array(); 
            #endregion

            #region foreach遍历
            //9,foreach遍历数组
            //ForEach(new int[]{2,3 }); 
            #endregion

            #region 冒泡排序
            //10，冒泡排序
            //Sort sort = new Sort();
            //sort.bubbleSort(new int[] { 2, 3,3,9,12,33,44,2,7, 2, 5, 8, 5, 9, 5, 7, 1, 4, 5 });

            #endregion

            #region 泛型
            //11，泛型
            //Generic<object> generic = new Generic<object>("fg");
            //Console.WriteLine(generic.Age);

            //用泛型改造之前代码，包括：取最大值、冒泡排序、快速排序
            //取最大值
            //FG<string> fG = new FG<string>();
            //fG.Max(new int[] { 2, 4, 3, 7, 9, 5, 6, 8, 0 });
            //fG.Max(new string[] { "2", "xl", "lc", "wx"}); 

            ////协变，逆变 out/in
            //IPeople<Clever> people = new  Man<Clever>();
            //IPeople<foolish> boy = new Man<foolish>();
            //boy = people;

            //#region 双向链表
            ////12，----双向链表
            ////----在后面添加节点
            //DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //DLinkNode<int> firstNode = new DLinkNode<int> { Content = 1 };
            //doubleLinkedList.AddOnTail(firstNode);
            ////case-1 => 1
            //Console.WriteLine(doubleLinkedList.Count == 1);
            ////case-1 => true
            //Console.WriteLine(firstNode == doubleLinkedList.Head);
            ////case-1 => true
            //Console.WriteLine(firstNode == doubleLinkedList.Tail);

            //DLinkNode<int> secondNode = new DLinkNode<int> { Content = 2 };
            //doubleLinkedList.AddOnTail(secondNode);

            ////case-2 =>node_2 的上一个节点是链表的头结点;
            //Console.WriteLine(secondNode.Previous == doubleLinkedList.Head);
            ////case-2 =>node_1 的下一个节点是node_2;
            //Console.WriteLine(firstNode.Next == secondNode);
            ////case-2 => 2
            //Console.WriteLine(doubleLinkedList.Count == 2);
            ////case-2 => 第一个节点仍然是头节点
            //Console.WriteLine(firstNode == doubleLinkedList.Head);
            ////case-2 => tail is node_2
            //Console.WriteLine(secondNode == doubleLinkedList.Tail);

            //DLinkNode<int> thirdNode = new DLinkNode<int> { Content = 3 };
            //doubleLinkedList.AddOnTail(thirdNode);
            ////case-3 =>node_3 的上一个节点是node_2;
            //Console.WriteLine(thirdNode.Previous == secondNode);
            ////case-3 =>node_2 的下一个节点是node_3;
            //Console.WriteLine(secondNode.Next == thirdNode);
            ////case-3 => 3
            //Console.WriteLine(doubleLinkedList.Count == 3);
            ////case-3 => true
            //Console.WriteLine(firstNode == doubleLinkedList.Head);
            ////case-3 => tail is node_3
            //Console.WriteLine(thirdNode == doubleLinkedList.Tail);
            ////case-3 => node_2 isn't tail  
            //Console.WriteLine(secondNode != doubleLinkedList.Head &&
            //    secondNode != doubleLinkedList.Tail);

            ////case-4 => 4
            //DLinkNode<int> fourthNode = new DLinkNode<int> { Content = 4 };
            //doubleLinkedList.AddOnTail(fourthNode);
            //Console.WriteLine(doubleLinkedList.Count == 4);

            //Console.WriteLine("----从头添加节点");

            //DLinkNode<int> fifthNode = new DLinkNode<int> { Content = 5 };
            //doubleLinkedList.AddOnHead(fifthNode);
            ////case-1 => 5
            //Console.WriteLine(doubleLinkedList.Head == fifthNode);
            //Console.WriteLine(doubleLinkedList.Count == 5);

            //Console.WriteLine("-----删除firstNode之前");
            //Console.WriteLine(firstNode.Previous == doubleLinkedList.Head);
            //Console.WriteLine(doubleLinkedList.Head.Next == firstNode);
            //Console.WriteLine(firstNode.Next == secondNode);
            //Console.WriteLine(secondNode.Previous == firstNode);
            //doubleLinkedList.Remove(firstNode);
            //Console.WriteLine("-----删除firstNode之后");
            //Console.WriteLine(doubleLinkedList.Count == 4);
            //Console.WriteLine(firstNode.Previous == null);
            //Console.WriteLine(firstNode.Next == null);
            //Console.WriteLine(fifthNode.Next == secondNode);
            //Console.WriteLine(secondNode.Previous == fifthNode);

            //Console.WriteLine("--删除fifthNode（头结点）之前");
            //Console.WriteLine(fifthNode.Previous == null);
            //Console.WriteLine(fifthNode.Next == secondNode);
            //Console.WriteLine(secondNode.Previous == fifthNode);
            //doubleLinkedList.Remove(fifthNode);
            //Console.WriteLine("-----删除fifthNode（头结点）之后");
            //Console.WriteLine(doubleLinkedList.Count == 3);
            //Console.WriteLine(fifthNode.Previous == null);
            //Console.WriteLine(fifthNode.Next == null);
            //Console.WriteLine(doubleLinkedList.Head == secondNode);
            //Console.WriteLine(secondNode.Previous == null);

            //Console.WriteLine("--删除fourthNode（尾节点）之前");
            //Console.WriteLine(fourthNode.Previous == thirdNode);
            //Console.WriteLine(fourthNode.Next == null);
            //Console.WriteLine(thirdNode.Next == fourthNode);
            //doubleLinkedList.Remove(fourthNode);
            //Console.WriteLine("--删除fourthNode（尾节点）之后");
            //Console.WriteLine(doubleLinkedList.Count == 2);
            //Console.WriteLine(fourthNode.Previous == null);
            //Console.WriteLine(fourthNode.Next == null);
            //Console.WriteLine(thirdNode.Next = null);

            //doubleLinkedList.Remove(thirdNode);
            //doubleLinkedList.Remove(secondNode);
            //Console.WriteLine("-- 删除所有节点");
            //Console.WriteLine(doubleLinkedList.Count == 0);
            //Console.WriteLine(doubleLinkedList.Head == null);
            //Console.WriteLine(doubleLinkedList.Tail == null);

            //Console.WriteLine("---------------");


            ////----节点数量
            ////Console.WriteLine($"节点数量=>{doubleLinkedList._count}");

            //////----在后面插入
            ////DLinkNode<int> sixthNode = new DLinkNode<int> { Content = 6 };
            ////doubleLinkedList.Insert(firstNode,sixthNode);
            //////case => 6
            ////Console.WriteLine($"Insert=>{doubleLinkedList.Head.Next.Next.Content}");

            //////----交换
            /////----5,1,6,2,3,4
            /////----首个和中间第5个交换
            ////Console.WriteLine("首个和中间第5个交换");      
            //////case-1 => 5
            ////Console.WriteLine($"交换{doubleLinkedList.Head.Content}");
            //////case-1 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            ////doubleLinkedList.Swap(thirdNode, fifthNode);
            //////case-1 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Content);
            //////case-1 => 5
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);

            //////----首尾交换
            ////Console.WriteLine("首尾交换");
            //////case-2 => 5
            ////Console.WriteLine(doubleLinkedList.Head.Content);
            //////case-2 => 4
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);
            ////doubleLinkedList.Swap(fourthNode, fifthNode);
            //////case-2 => 4
            ////Console.WriteLine(doubleLinkedList.Head.Content);
            //////case-2 => 5
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);

            //////----末尾和中间第3个交换
            ////Console.WriteLine("末尾和中间第3个交换");
            //////case-3 => 6
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Content);
            //////case-3 => 4
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);
            ////doubleLinkedList.Swap(fourthNode, sixthNode);
            //////case-3 => 4
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Content);
            //////case-3 => 6
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);

            //////----中间相隔交换
            ////Console.WriteLine("----中间相隔交换");
            //////case-7 => 1
            ////Console.WriteLine(doubleLinkedList.Head.Next.Content);
            //////case-7 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            ////doubleLinkedList.Swap(firstNode, thirdNode);
            //////case-7 => 1
            ////Console.WriteLine(doubleLinkedList.Head.Next.Content);
            //////case-7 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);

            //////----中间相邻交换
            ////Console.WriteLine("----中间相邻交换");
            //////case-4 => 2
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Content);
            //////case-4 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            ////doubleLinkedList.Swap(secondNode, thirdNode);
            //////case-4 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Content);
            //////case-4 => 2
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);

            //////----末尾相邻交换
            ////Console.WriteLine("----末尾相邻交换");
            //////case-5 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            //////case-5 => 4
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);
            ////doubleLinkedList.Swap(fourthNode, thirdNode);
            //////case-5 => 4
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            //////case-5 => 3
            ////Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);

            //////----头部相邻交换
            ////Console.WriteLine("----头部相邻交换");
            //////case-6 => 5
            ////Console.WriteLine(doubleLinkedList.Head.Content);
            //////case-6 => 1
            ////Console.WriteLine(doubleLinkedList.Head.Next.Content);
            ////doubleLinkedList.Swap(firstNode, fifthNode);
            //////case-6 => 5
            ////Console.WriteLine(doubleLinkedList.Head.Content);
            //////case-6' => 1
            ////Console.WriteLine(doubleLinkedList.Head.Next.Content);

            //#endregion

            #endregion

            #region 泛型集合
            //13,泛型集合
            //foreach (var item in doubleLinkedList)
            //{
            //    Console.WriteLine(item);
            //}

            //调用扩展方法Max()
            DoubleLinkedList<int> Node = new DoubleLinkedList<int>();
            Node.Max();

            //一篇文章可以有多个评论
            Comment goodComment = new Comment { content = "好评" };

            Comment mediumComment = new Comment { content = "中评" };

            Comment badComment = new Comment { content = "差评" };
            Article article = new Article { comment = new List<Comment> { goodComment, badComment } };

            //一个评论必须有一个它所评论的文章
            goodComment.article = article;

            //每个文章和评论都有一个评价
            Appraise appraise = new Appraise();
            article.appraise = appraise;
            goodComment.appraise = appraise;

            //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
            KeyWord Csharp = new KeyWord { name = "C#" };
            KeyWord SQL = new KeyWord { name = "SQL" };
            KeyWord Javascript = new KeyWord { name = "Javascript" };
            KeyWord Net = new KeyWord { name = ".NET" };

            User fg = new User { name = "飞哥" };
            User xy = new User { name = "小余" };
            User aj = new User { name = "阿杰" };

            Article LifeArticle = new Article
            {
                keyWords = new List<KeyWord> { Csharp, SQL, Net },
                Author = fg,
                Title = "飞哥有才华",
                date = new DateTime(2019, 2, 2),
                comment = new List<Comment> { goodComment, mediumComment },
                
            };
            Article StudyArticle = new Article
            {
                keyWords = new List<KeyWord> { Csharp, SQL, Javascript },
                Author = xy,
                Title = "小鱼吃大鱼",
                date = new DateTime(2019, 1, 2),
                comment = new List<Comment> { goodComment, mediumComment, badComment }

            };
            Article eatArticle = new Article
            {
                keyWords = new List<KeyWord> { SQL, Javascript },
                Author = xy,
                Title = "小鱼吃饭",
                date = new DateTime(2019, 3, 2),
                comment = new List<Comment> { badComment }

            };

            Csharp.articles = new List<Article> { LifeArticle, StudyArticle };

            #endregion

            #region 匿名类
            ////15,匿名类-----区别于无名对象new Child ()
            //var g = new { name="fg",age=18};
            //Console.WriteLine(g.GetType());

            ////索引
            //Index index = new Index();
            //index._score = new int[10];
            //index[0] = 1;
            //index[1] = 2;
            //Console.WriteLine(index[1]);
            //foreach (var item in index._score)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Linq
            //14,----Linq
            Teacher XY = new Teacher { teachers = "小余", age = 25 };
            Teacher FG = new Teacher { teachers = "飞哥", age = 38 };
            Teacher AJ = new Teacher { teachers = "阿杰", age = 38 };


            Classmate xl = new Classmate { name = "xl", age = 21, teacher = XY };
            Classmate lm = new Classmate { name = "lm", age = 18, teacher = XY };
            Classmate wx = new Classmate { name = "wx", age = 25, teacher = FG };

            IList<Classmate> yz = new List<Classmate> { xl, lm, wx };
            Problem fgProblem = new Problem {Reward=6,Author=fg };
            Problem xyProblem = new Problem { Reward = 3,Author=xy };
            Problem xyStudyProblem = new Problem { Reward = 4,Author=xy };
            List<Problem> problems = new List<Problem> {fgProblem,xyProblem,xyStudyProblem };
            //where条件筛选
            //var goodboy = from b in yz
            //              where b.name.StartsWith("l")
            //              select b;
            //foreach (var item in goodboy)
            //{
            //    Console.WriteLine(item.name);

            //}

            //排序
            //var order = from o in yz
            //            orderby o.age ascending    //降序 descending
            //            select o;
            //foreach (var item in order)
            //{
            //    Console.WriteLine(item.name+","+item.age);
            //}

            //分组
            //var group = from gr in yz
            //group gr by gr.teacher;

            //投影
            //var select = from gr in yz
            //group gr by gr.teacher into gm
            //            select new { teacher = gm.Key, count = gm.Count() };
            //foreach (var item in select)
            //{
            //    Console.WriteLine(item.teacher.teachers+","+item.count);
            //}

            //连接，内连接
            //var join = from y in yz
            //           join z in new List<Teacher> { xy, fg }
            //           on y.teacher equals z into YZ
            //           from r in YZ.DefaultIfEmpty()
            //           select new { Majors = y.name, teacher = r.teachers };

            //左连接，关键字（DefaultIfEmpty）
            //var join = from z in new List<Teacher> { xy, fg }
            //           join y in yz
            //           on z equals y.teacher into YZ
            //           from r in YZ.DefaultIfEmpty()
            //           select new { teacher = z.teachers, Majors = r?.name ?? "没有课程"};

            //连接后分组
            //var join = from z in new List<Teacher> { xy, fg, aj }
            //           join y in yz
            //           on z equals y.teacher into YZ
            //           from r in YZ.DefaultIfEmpty()
            //           select new { Key = z.teachers, value = YZ };
            //foreach (var item in join)
            //{
            //    Console.WriteLine(item.Key + "," + item.value);
            //}

            //#region Link作业 1

            ////找出“飞哥”发布的文章
            List<Article> ts = new List<Article> { eatArticle, LifeArticle, StudyArticle };
            //var fgArticle = from a in ts
            //                where a.Author.name == "飞哥"
            //                select a;
            //foreach (var item in fgArticle)
            //{
            //    Console.WriteLine(item.Title);

            //}
            ////找出2019年1月1日以后“小鱼”发布的文章
            //var xyArticle = from b in ts
            //                where b.date > new DateTime(2019, 1, 1) && b.Author.name == "小余"
            //                select b;
            //foreach (var item in xyArticle)
            //{
            //    Console.WriteLine(item.Title);
            //}
            ////按发布时间升序 / 降序排列显示文章
            //var publicTime = from c in ts
            //                 orderby c.date ascending     //desending
            //                 select c;
            //foreach (var item in publicTime)
            //{
            //    Console.WriteLine(item.Title + "," + item.date);
            //}
            ////统计每个用户各发布了多少篇文章
            //var publicCount = from d in new List<User> { fg, xy }
            //                  join e in ts
            //                  on d equals e.Author into de
            //                  from f in de.DefaultIfEmpty()
            //                  select new { key = d, value = de.Count() };
            //foreach (var item in publicCount)
            //{
            //    Console.WriteLine(item.key.name + "," + item.value);
            //}
            ////找出包含关键字“C#”或“.NET”的文章 
            ////var KeyWordArticle = from g in ts
            ////                     let ks = g.keyWords
            ////                     from k in ks
            ////                     where k.name == "C#" || k.name == ".NET"
            ////                     select g;

            //var KeyWordArticle = from g in ts
            //                     where g.keyWords.Any(
            //                         k => k.name == "C#" || k.name == ".NET")
            //                     select g;

            //foreach (var item in KeyWordArticle/*.Distinct()*/)
            //{
            //    Console.WriteLine(item.Title);
            //}
            ////找出评论数量最多的文章
            ////var CommentMost = from j in ts
            ////                  where j.comment





            //#endregion

            #region Link作业 2
            //    找出每个作者最近发布的一篇文章
            //为求助（Problem）添加悬赏（Reward）属性，
            //并找出每一篇求助的悬赏都大于5个帮帮币的文章作者


            #endregion
            var RecentlyPublic = ts.OrderByDescending(o=>o.date).GroupBy(g => g.Author.name);
            var x = RecentlyPublic.SelectMany(s => s, (s, m) => new { s, m });

            foreach (var item in x)
            {
                Console.WriteLine($"{item.m.Title}:{item.m.date}");
            }


            #endregion

            #region Lambda表达式，委托
            //委托
            //Delegate.AddDel(1, 2, Delegate.Add);
            //Delegate.rootingDel(2, Delegate.rooting);

            //委托和事件
            //Button button = new Button();
            //button.OnClick += Button_OnClick;
            //button.click(); 

            //Func<string, Fathers> father = (name) =>
            //{
            //    return new Fathers();
            //};
            //Func<string, Children> children = (name) =>
            //   {
            //       return new Children();
            //   };

            //father = children;
            //father();
            ////children = father;
            //children();
            #endregion

            Console.Read();
        }

        private static void Button_OnClick(object sender, EventArgs e)
        {
            Console.WriteLine("点击事件");
        }

        static void ForEach<T>(T[] array)
        {
            foreach (T j in array)
            {
                Console.WriteLine(j);
            }
        }
        static void school(string name)
        {

            char[] input = name.ToCharArray();
            char[] output = new char[input.Length];


            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[input.Length - 1 - i];
            }

            Console.WriteLine(output);
        }
        static void Date()
        {
            DateTime date = new DateTime(2019,1,1);
            for (int day = 1; day < 7; day++)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    break;
                }
                else
                {
                    date = date.AddDays(1);
                }
            }
            Console.WriteLine($"{date.Year}年{date.Month}月{date.Day}日为该年第一个星期一");

            int week = 1;
            bool success = false;

            DateTime expiryDate = date;
            while (!success)
            {
                if (expiryDate.Year < 2020)
                {
                    DateTime Todate = date.AddDays((7 * week) - 7);
                    Console.Write($"第{week}周:{Todate.Year}年{Todate.Month}月{Todate.Day}日-");
                    expiryDate = date.AddDays(7 * week - 1);
                    Console.WriteLine($"{expiryDate.Year}年{expiryDate.Month}月{expiryDate.Day}日");
                    Console.WriteLine();
                    week++;
                }
                else
                {
                    success = false;
                }
            }
        }
    }


    class Mimicstact
    {
        private object[] array = null;
        private int top;
        public Mimicstact(int Length)
        {
            array = new object[Length];
        }
        internal void Push(params object[] value)
        {

            if (top == array.Length)
            {
                Console.WriteLine("栈溢出");
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    array[top] = value[i];
                    top++;
                    Console.Write($"{value[i]},");
                }

                Console.WriteLine("入栈");

                ArrayShow.Inline(array);
                Console.WriteLine();
                Console.WriteLine("--------------------");
            }



        }
        internal void pop()
        {
            Console.WriteLine($"{array[top - 1]}出栈");
            array[top - 1] = 0;
            top--;
            ArrayShow.Inline(array);
            Console.WriteLine();
            Console.WriteLine("--------------------");
            if (top == array.Length)
            {
                Console.WriteLine("栈溢出");
            }
            else if (top == 0)
            {
                Console.WriteLine("栈已空");
            }
        }

    }
    class ArrayShow
    {
        internal static void Inline(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + "   ");
            }
        }
    }
    class Date
    {
        internal DateTime date1 = new DateTime(2019, 3, 6);

        internal void DateCalculation()
        {
            Console.WriteLine($"当前日期{date1.Year}年{date1.Month}月{date1.Day}日请输入：");
            string input = Convert.ToString(Console.ReadLine());
            string integer = input.Substring(0, input.Length - 1);
            string Chinese = input.Substring(input.Length - 1);
            int integer1 = Convert.ToInt32(integer);
            if (Chinese == "周")
            {
                DateTime end = date1.AddDays(integer1 * 7);
                Console.WriteLine($"{input}过后的日期为：{end.Year}年{end.Month}月{end.Day}日");
            }
            if (Chinese == "月")
            {
                DateTime end = date1.AddMonths(integer1);
                Console.WriteLine($"{input}过后的日期为：{end.Year}年{end.Month}月{end.Day}日");
            }
            if (Chinese == "日")
            {
                DateTime end = date1.AddDays(integer1);
                Console.WriteLine($"{input}过后的日期为：{end.Year}年{end.Month}月{end.Day}日");
            }
        }

    }
    internal class FG<T> where T : IComparable/*, IConvertible*/
    {
        //public FG(T a, T b)
        //{

        //    if (a.CompareTo(b)>0)
        //    {

        //    }
        //}
        internal void Max(T[] array)
        {
            T max = array[0];
            Console.WriteLine($"最大值的初始值为:{max}");
            for (int i = 1; i < array.Length; i++)
            {             //泛型不能用运算符
                if (array[i].CompareTo(max) > 0)
                {
                    Console.WriteLine($"第{i}次比较，{array[i]}>{max},目前最大值为{array[i]}"); max = array[i];

                }
                else
                {
                    Console.WriteLine($"第{i}次比较，{array[i]}<={max},最大值不变" + max);
                }
            }
            Console.WriteLine($"最终结果，最大值为{max}");
        }

    }

}

