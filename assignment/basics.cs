using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    class callMethod
    {
        public static void referenceTypeCast()
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
        }

        public static void getSet()
        {
            #region 属性
            //2，属性
            //getSet get = new getSet();
            //get.Age = 4;
            //Console.WriteLine(get.Age);  
            #endregion
        }


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



        #region 泛型练习
        //11，泛型
        //Generic<object> generic = new Generic<object>("fg");
        //Console.WriteLine(generic.Age);

        //用泛型改造之前代码，包括：取最大值、冒泡排序、快速排序
        //取最大值
        //FG<string> fG = new FG<string>();
        //fG.Max(new int[] { 2, 4, 3, 7, 9, 5, 6, 8, 0 });
        //fG.Max(new string[] { "2", "xl", "lc", "wx"}); 

        //协变，逆变 out/in
        //IPeople<Clever> people = new Man<Clever>();
        //IPeople<foolish> boy = new Man<foolish>();
        //boy = people; 
        #endregion


        #region 泛型集合
        ////13,泛型集合
        ////foreach (var item in doubleLinkedList)
        ////{
        ////    Console.WriteLine(item);
        ////}

        ////调用扩展方法Max()
        ////DoubleLinkedList<int> Node = new DoubleLinkedList<int>();
        ////Node.Max();

        ////一篇文章可以有多个关键字，
        //KeyWord Csharp = new KeyWord { name = "C#" };
        //KeyWord SQL = new KeyWord { name = "SQL" };
        //KeyWord Javascript = new KeyWord { name = "Javascript" };
        //KeyWord Net = new KeyWord { name = ".NET" };

        //User fg = new User("飞哥");
        //User xy = new User("小余");
        //User aj = new User("阿杰");


        //Article article = new Article(new Content(xy, "大飞鱼", "鲲鹏的后代飞行速度极快", new DateTime(2019, 6, 2)))
        //{
        //    keyWords = new List<KeyWord> { Csharp, SQL }
        //};
        //article.Public(new TRepository<Article>());
        //Article LifeArticle = new Article(new Content(fg, "才华", "飞哥有才华", new DateTime(2019, 2, 2)))
        //{
        //    keyWords = new List<KeyWord> { Csharp, SQL, Net }
        //};
        //LifeArticle.Public(new TRepository<Article>());
        //Article StudyArticle = new Article(new Content(xy, "大鱼", "小鱼吃大鱼", new DateTime(2019, 1, 2)))
        //{
        //    keyWords = new List<KeyWord> { Csharp, SQL, Javascript }

        //};
        //StudyArticle.Public(new TRepository<Article>());
        //Article eatArticle = new Article(new Content(xy, "小鱼", "小鱼吃饭", new DateTime(2019, 3, 2)))
        //{
        //    keyWords = new List<KeyWord> { SQL, Javascript }
        //};
        //eatArticle.Public(new TRepository<Article>());

        ////一个关键字可以对应多篇文章
        //Csharp.articles = new List<Article> { LifeArticle, StudyArticle };


        ////一个评论必须有一个它所评论的文章
        //Comment goodComment = new Comment(LifeArticle) { content = "好评" };
        //Comment mediumComment = new Comment(StudyArticle) { content = "中评" };
        //Comment badComment = new Comment(eatArticle) { content = "差评" };

        ////一篇文章可以有多个评论
        //article.comment = new List<Comment> { goodComment, badComment };
        //LifeArticle.comment = new List<Comment> { goodComment, mediumComment };
        //StudyArticle.comment = new List<Comment> { goodComment, mediumComment, badComment };
        //eatArticle.comment = new List<Comment> { badComment };

        ////每个文章和评论都有一个评价
        //article.appraise = new Appraise();
        //goodComment.appraise = new Appraise();



        //#endregion

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

        //#region Linq
        ////14,----Linq
        //Teacher XY = new Teacher { teachers = "小余", age = 25 };
        //Teacher FG = new Teacher { teachers = "飞哥", age = 38 };
        //Teacher AJ = new Teacher { teachers = "阿杰", age = 38 };


        //Classmate xl = new Classmate { name = "xl", age = 21, teacher = XY };
        //Classmate lm = new Classmate { name = "lm", age = 18, teacher = XY };
        //Classmate wx = new Classmate { name = "wx", age = 25, teacher = FG };

        //IList<Classmate> yz = new List<Classmate> { xl, lm, wx };
        //Article fgProblem = new Article(new Content(fg, "飞哥", "我要健身", new DateTime(2019, 6, 2))) { Reward = 6 };
        //Article xyProblem = new Article(new Content(xy, "饥饿", "几天没吃吃饭", new DateTime(2019, 6, 5))) { Reward = 3 };
        //Article xyStudyProblem = new Article(new Content(xy, "小龙虾", "好想吃小龙虾", new DateTime(2019, 6, 12))) { Reward = 4 };
        //List<Article> problems = new List<Article> { fgProblem, xyProblem, xyStudyProblem };
        ////where条件筛选
        ////var goodboy = from b in yz
        ////              where b.name.StartsWith("l")
        ////              select b;
        ////foreach (var item in goodboy)
        ////{
        ////    Console.WriteLine(item.name);

        ////}

        ////排序
        ////var order = from o in yz
        ////            orderby o.age ascending    //降序 descending
        ////            select o;
        ////foreach (var item in order)
        ////{
        ////    Console.WriteLine(item.name+","+item.age);
        ////}

        ////分组
        ////var group = from gr in yz
        ////group gr by gr.teacher;

        ////投影
        ////var select = from gr in yz
        ////group gr by gr.teacher into gm
        ////            select new { teacher = gm.Key, count = gm.Count() };
        ////foreach (var item in select)
        ////{
        ////    Console.WriteLine(item.teacher.teachers+","+item.count);
        ////}

        ////连接，内连接
        ////var join = from y in yz
        ////           join z in new List<Teacher> { xy, fg }
        ////           on y.teacher equals z into YZ
        ////           from r in YZ.DefaultIfEmpty()
        ////           select new { Majors = y.name, teacher = r.teachers };

        ////左连接，关键字（DefaultIfEmpty）
        ////var join = from z in new List<Teacher> { xy, fg }
        ////           join y in yz
        ////           on z equals y.teacher into YZ
        ////           from r in YZ.DefaultIfEmpty()
        ////           select new { teacher = z.teachers, Majors = r?.name ?? "没有课程"};

        ////连接后分组
        ////var join = from z in new List<Teacher> { xy, fg, aj }
        ////           join y in yz
        ////           on z equals y.teacher into YZ
        ////           from r in YZ.DefaultIfEmpty()
        ////           select new { Key = z.teachers, value = YZ };
        ////foreach (var item in join)
        ////{
        ////    Console.WriteLine(item.Key + "," + item.value);
        ////}

        ////#region Link作业 1

        //////找出“飞哥”发布的文章
        //List<Article> ts = new List<Article> { eatArticle, LifeArticle, StudyArticle };
        ////var fgArticle = from a in ts
        ////                where a.Author.name == "飞哥"
        ////                select a;
        ////foreach (var item in fgArticle)
        ////{
        ////    Console.WriteLine(item.Title);
        ////}
        //////找出2019年1月1日以后“小鱼”发布的文章
        ////var xyArticle = from b in ts
        ////                where b.date > new DateTime(2019, 1, 1) && b.Author.name == "小余"
        ////                select b;
        ////foreach (var item in xyArticle)
        ////{
        ////    Console.WriteLine(item.Title);
        ////}
        //////按发布时间升序 / 降序排列显示文章
        ////var publicTime = from c in ts
        ////                 orderby c.date ascending     //desending
        ////                 select c;
        ////foreach (var item in publicTime)
        ////{
        ////    Console.WriteLine(item.Title + "," + item.date);
        ////}
        //////统计每个用户各发布了多少篇文章
        ////var publicCount = from d in new List<User> { fg, xy }
        ////                  join e in ts
        ////                  on d equals e.Author into de
        ////                  from f in de.DefaultIfEmpty()
        ////                  select new { key = d, value = de.Count() };
        ////foreach (var item in publicCount)
        ////{
        ////    Console.WriteLine(item.key.name + "," + item.value);
        ////}
        //////找出包含关键字“C#”或“.NET”的文章 
        //////var KeyWordArticle = from g in ts
        //////                     let ks = g.keyWords
        //////                     from k in ks
        //////                     where k.name == "C#" || k.name == ".NET"
        //////                     select g;

        ////var KeyWordArticle = from g in ts
        ////                     where g.keyWords.Any(
        ////                         k => k.name == "C#" || k.name == ".NET")
        ////                     select g;

        ////foreach (var item in KeyWordArticle/*.Distinct()*/)
        ////{
        ////    Console.WriteLine(item.Title);
        ////}
        ////找出评论数量最多的文章
        ////var CommentOrder = from j in ts
        ////                   orderby j.comment.Count() descending
        ////                   select j;
        ////var CommentMost = CommentOrder.First();
        ////Console.WriteLine(CommentMost.Title);






        //#endregion

        //#region Link作业 2
        ////    找出每个作者最近发布的一篇文章
        ////为求助（Problem）添加悬赏（Reward）属性，
        ////并找出每一篇求助的悬赏都大于5个帮帮币的文章作者

        ////var RecentlyPublic = new TRepository<Article>().Get().OrderByDescending(o => o.Content._date).GroupBy(g => g.Content.Author);
        ////var a = RecentlyPublic.First();
        ////foreach (var item in a)
        ////{

        ////    Console.WriteLine($"{item.Content.Author.Name}:{item.Content.Title}:{item.Content._date}");
        ////}
        //#endregion

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

        public static void XML()
        {
            #region XML作业
            //按以下格式生成一个XML对象： 
            XElement bang = new XElement(
                "articles", new XComment("!--以下存放所有“源栈”所有文章--"),
                new XElement(
                    "article", new XAttribute("isDraft", "false"),
                     new XElement("id", 1),
                     new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                     new XElement("body", "什么是XML（EXtensible Markup " +
                     "Language）是一种文本文件格式被设计用来传输和存储数据由：" +
                     "标签和属性组成元素（节点），由元素组成“树状结构”必须" +
                     "有而且只能有一个根节点其他："),
                     new XElement("authorId", 1),
                     new XElement("publishDate", "2019/6/18 18:15"),
                     new XElement(
                         "comments",
                         new XElement(
                         "comment", new XAttribute("recommend", "true"),
                         new XElement("id", 12),
                         new XElement("body", "不错，赞!"),
                         new XElement("authorId", 2)
                         ),
                         new XElement(
                         "comment", new XElement("id", 14),
                         new XElement("body", "作业太难了"),
                         new XElement("authorId", "3")
                         )
                     )
                 ),
                 new XElement(
                     "article",
                     new XAttribute("isDraft", "true"),
                     new XElement("id", 2),
                     new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                     new XElement("authorId", 1)
                  )
            );

            //然后，将其以文件形式存放到磁盘中； 
            //bang.Save(@"C:\17bang\fg\ban");

            //再从磁盘中读取到内存中。 
            //XElement element = XElement.Load(@"C:\17bang\fg\ban");

            //在根节点下添加一个新的article元素，内容至少包含id、title和authorId
            //element.Add(new XElement("article",
            //   new XElement("id", "3"),
            //   new XElement("title", "今天作业好多啊！"),
            //   new XElement("authorId", "3")
            //   )
            //);

            //删除id = 12的评论
            //方法1
            //var commen = element.Descendants("comment").Where(w => w.Element("id").Value == 12.ToString());
            //commen.Remove();

            //方法2
            //IEnumerable <XElement> comment = element.Element("article")
            //   .Element("comments").Elements();
            //var targetcomment = commen.Where(w => Convert.ToInt32(w.Element("id").Value) == 12);
            //targetcomment.Remove();

            //  改变id = 2的article：isDraft = false，title = 源栈培训：C#进阶-8：异步和并行 
            //var articlelist = element.Elements().Where(w => Convert.ToInt32(w.Element("id").Value) == 2).Single();
            //articlelist.SetAttributeValue("isDraft", "false");
            //articlelist.Element("title").SetValue("源栈培训：C#进阶-8：异步和并行");

            //参照上述articles，代码生成一个XML的users对象，能够存放用户的id、name和password，然后并存放到磁盘
            //扩展user和articles的内容，使其能够完成以下操作： 
            //根据用户名查找他发布的全部文章
            //统计出每个用户各发表了多少篇文章
            //查出每个用户最近发布的一篇文章
            //每个用户评论最多的一篇文章
            //删除没有发表文章的用户
            //XElement users = new XElement(
            //    "user",
            //    new XElement("id", 1),
            //    new XElement("name", "龙顺金"),
            //    new XElement("password", 1234)
            //    );
            //element.Elements("article").Where(w => w.Element("id").Value == 1.ToString()).Single().AddFirst(users);
            //var art = element.Elements("article").Where(w => w.Element("id").Value == 2.ToString()).Single();
            //art.AddFirst(users);

            //art.Add(new XElement("publishDate", "2019,6,19"));
            //art.Add(
            //        ); 
            //Console.WriteLine(element);
            #endregion
        }


        public static void toRepeat()
        {
            #region 作业----去重复
            /*
               * 现有一个txt文件，里面存放了若干email地址，使用分号（;）
               * 或者换行进行了分隔。请删除其中重复的email地址，并按每30个
               * email一行（行内用;分隔）重新组织
               * 测试1
               * removeRepeatTest()=>没有输出“有重复”
               * 
               * */
            //removeRepeat(@"C:\17bang\yzHomework\email.txt"); 
            #endregion
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
            DateTime date = new DateTime(2019, 1, 1);
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
        static IList<string> removeRepeat(string path)
        {
            IEnumerable<string> emailFile = File.ReadLines(path);
            IList<string> emailList = new List<string>();
            int x = 0, y = 0;
            foreach (var item in emailFile)
            {

                string[] email = item.Split(";");
                using (StreamWriter writer = File.AppendText(@"C:\17bang\yzHomework\emailList.txt"))
                {
                    foreach (var i in email)
                    {
                        if (!emailList.Contains(i))
                        {
                            emailList.Add(i);
                            x++;

                            writer.Write(i + " ; ");

                            Console.Write(i + " ; ");
                            if (x == 30)
                            {
                                x = 0;
                                Console.WriteLine();
                                Console.WriteLine();
                                writer.WriteLine();
                                writer.WriteLine();

                            }
                        }
                        else
                        {
                            y++;
                        }
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"有{y}处重复被去除");
            //StreamWriter writer = File.CreateText(@"C:\17bang\yzHomework\emailList.txt");



            return emailList;
        }
        static void removeRepeatTest()
        {

            IList<string> emailList = new List<string>();
            foreach (var item in removeRepeat(@"C:\17bang\yzHomework\email.txt"))
            {
                if (!emailList.Contains(item))
                {
                    emailList.Add(item);
                }
                else
                {
                    Console.WriteLine("有重复");
                }
            }
        }

    }
    //引用类型的类型转换
    class Basics
    {
        internal void BasicsTry()
        {
            Console.WriteLine("父类");
        }
    }
    class Child : Basics
    {
        //internal void ChildTry()
        //{
        //    Console.WriteLine("子类");
        //}
    }
    //索引
    class Index
    {
        internal int[] _score;
        internal int this[int index]
        {
            get { return _score[index]; }
            set { _score[index] = value; }

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
    internal class FG<T> where T : IComparable, IConvertible
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
