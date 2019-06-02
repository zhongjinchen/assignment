using System;
using System.Collections.Generic;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1，引用类型的类型转换
            Basics basics = new Child();
            Child child = (Child)basics;


            //2，属性
            //getSet get = new getSet();
            //get.Age = 4;
            //Console.WriteLine(get.Age);

            //3，值类型传递是copy
            //int i = 8;
            //int j = i;
            //Console.WriteLine(i);     --i还有值

            //4，
            //Console.WriteLine(typeof(char));
            //多态练习
            //Father father = new Son();    //----父类的实例指向子类的引用
            //father.Fly();
            ////Console.WriteLine(father.Bird());
            //Dad dad = new Boy();
            //dad.Eat();

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

            //6，模拟出入栈
            //Mimicstact imitate = new Mimicstact(5);
            //imitate.Push(new object[] {"xl"});  //调用用params（参数数组）方法既可以传递
            //imitate.Push("is", true);         //一个数组实参如(new int[] { 8 })，也可以传递一组数字如（2，2，4）
            //imitate.pop();
            //imitate.Push(10, 3);
            //imitate.Push(4);
            //imitate.Push(7);

            ////7，
            // Bueaty bueaty = new Bueaty(20);
            //// bueaty.toBueaty();
            // Console.WriteLine(bueaty.toBueaty);
            //Bueaty BueatyHeight = new Bueaty(170);
            //  bueaty.Bueatyheight(168);

            // bueaty.Age = 100;
            // Console.WriteLine(bueaty.Age);
            //Console.WriteLine(bueaty.Height);
            //Child money = new Child();
            //Console.WriteLine(money.Tomoney);
            //school("yuanzhan");
            //Date date = new Date();
            //Beautyliu liu = new Beautyliu();
            //liu.beauty = 30;

            //8，使用object改造数据结构栈（Stack），并在出栈时获得出栈元素      
            //ObjectHomeWork objectHomeWork = new ObjectHomeWork(new object[] { });
            //objectHomeWork.Array();

            //9,foreach遍历数组
            //ForEach(new int[]{2,3 });

            //10，冒泡排序
            //Sort sort = new Sort();
            //sort.bubbleSort(new int[] { 2, 3,3,9,12,33,44,2,7, 2, 5, 8, 5, 9, 5, 7, 1, 4, 5 });


            //11，泛型
            //Generic<object> generic = new Generic<object>("fg");
            //Console.WriteLine(generic.Age);

            //用泛型改造之前代码，包括：取最大值、冒泡排序、快速排序
            //取最大值
            //FG<string> fG = new FG<string>();
            //fG.Max(new int[] { 2, 4, 3, 7, 9, 5, 6, 8, 0 });
            //fG.Max(new string[] { "2", "xl", "lc", "wx"});

            ////12，----双向链表
            //----在后面添加节点
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            DLinkNode<int> firstNode = new DLinkNode<int> { Content = 1 };
            doubleLinkedList.AddAfter(firstNode);
            //case-1 => 1
            Console.WriteLine($"在后面添加节点=>{doubleLinkedList.Count}");
            //case-1 => true
            Console.WriteLine(firstNode == doubleLinkedList.Head);
            //case-1 => true
            Console.WriteLine(firstNode == doubleLinkedList.Tail);

            DLinkNode<int> secondNode = new DLinkNode<int> { Content = 2 };
            doubleLinkedList.AddAfter(secondNode);

            //case-2 =>node_2 的上一个节点是链表的头结点;
            Console.WriteLine(secondNode.Previous == doubleLinkedList.Head);
            //case-2 =>node_1 的下一个节点是node_2;
            Console.WriteLine(firstNode.Next == secondNode);
            //case-2 => 2
            Console.WriteLine(doubleLinkedList.Count);
            //case-2 => true
            Console.WriteLine(firstNode == doubleLinkedList.Head);
            //case-2 => tail is node_2
            Console.WriteLine(secondNode == doubleLinkedList.Tail);

            DLinkNode<int> thirdNode = new DLinkNode<int> { Content = 3 };
            doubleLinkedList.AddAfter(thirdNode);
            //case-3 =>node_3 的上一个节点是node_2;
            Console.WriteLine(thirdNode.Previous == secondNode);
            //case-3 =>node_2 的下一个节点是node_3;
            Console.WriteLine(secondNode.Next == thirdNode);
            //case-3 => 3
            Console.WriteLine(doubleLinkedList.Count);
            //case-3 => true
            Console.WriteLine(firstNode == doubleLinkedList.Head);
            //case-3 => tail is node_3
            Console.WriteLine(thirdNode == doubleLinkedList.Tail);
            //case-3 => node_2 isn't tail  
            Console.WriteLine(secondNode != doubleLinkedList.Tail);

            //case-4 => 4
            DLinkNode<int> fourthNode = new DLinkNode<int> { Content = 4 };
            doubleLinkedList.AddAfter(fourthNode);
            Console.WriteLine(doubleLinkedList.Count);


            // ----在前面添加节点
            DLinkNode<int> fifthNode = new DLinkNode<int> { Content = 5 };
            doubleLinkedList.Addbefore(fifthNode);
            //case-1 => 5
            Console.WriteLine($"在前面添加节点=>{doubleLinkedList.Head.Content}");

            //-----删除节点
            //doubleLinkedList.Remove(firstNode);
            ////case-1 => true
            //Console.WriteLine($"删除节点=>{firstNode.Previous == null}");
            //Console.WriteLine(firstNode.Next == null);

            //doubleLinkedList.Remove(secondNode);
            ////case-2 => true
            //Console.WriteLine(secondNode.Previous == null);
            //Console.WriteLine(secondNode.Next == null);

            //doubleLinkedList.Remove(thirdNode);
            ////case-3 => true
            //Console.WriteLine(thirdNode.Previous == null);
            //Console.WriteLine(thirdNode.Next == null);
            //Console.WriteLine(thirdNode.Previous);

            //----节点数量
            //Console.WriteLine($"节点数量=>{doubleLinkedList._count}");

            //----在后面插入
            DLinkNode<int> sixthNode = new DLinkNode<int> { Content = 6 };
            doubleLinkedList.Insert(firstNode,sixthNode);
            //case => 6
            Console.WriteLine($"Insert=>{doubleLinkedList.Head.Next.Next.Content}");

            ////----交换
            ///----5,1,6,2,3,4
            ///----首个和中间第5个交换
            //Console.WriteLine("首个和中间第5个交换");      
            ////case-1 => 5
            //Console.WriteLine($"交换{doubleLinkedList.Head.Content}");
            ////case-1 => 3
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            //doubleLinkedList.Swap(thirdNode, fifthNode);
            ////case-1 => 3
            //Console.WriteLine(doubleLinkedList.Head.Content);
            ////case-1 => 5
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);

            ////----首尾交换
            //Console.WriteLine("首尾交换");
            ////case-2 => 5
            //Console.WriteLine(doubleLinkedList.Head.Content);
            ////case-2 => 4
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);
            //doubleLinkedList.Swap(fourthNode, fifthNode);
            ////case-2 => 4
            //Console.WriteLine(doubleLinkedList.Head.Content);
            ////case-2 => 5
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);

            ////----末尾和中间第3个交换
            //Console.WriteLine("末尾和中间第3个交换");
            ////case-3 => 6
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Content);
            ////case-3 => 4
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);
            //doubleLinkedList.Swap(fourthNode, sixthNode);
            ////case-3 => 4
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Content);
            ////case-3 => 6
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);

            ////----中间相隔交换
            //Console.WriteLine("----中间相隔交换");
            ////case-7 => 1
            //Console.WriteLine(doubleLinkedList.Head.Next.Content);
            ////case-7 => 3
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            //doubleLinkedList.Swap(firstNode, thirdNode);
            ////case-7 => 1
            //Console.WriteLine(doubleLinkedList.Head.Next.Content);
            ////case-7 => 3
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);

            ////----中间相邻交换
            //Console.WriteLine("----中间相邻交换");
            ////case-4 => 2
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Content);
            ////case-4 => 3
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            //doubleLinkedList.Swap(secondNode, thirdNode);
            ////case-4 => 3
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Content);
            ////case-4 => 2
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);

            ////----末尾相邻交换
            //Console.WriteLine("----末尾相邻交换");
            ////case-5 => 3
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            ////case-5 => 4
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);
            //doubleLinkedList.Swap(fourthNode, thirdNode);
            ////case-5 => 4
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Content);
            ////case-5 => 3
            //Console.WriteLine(doubleLinkedList.Head.Next.Next.Next.Next.Next.Content);

            ////----头部相邻交换
            //Console.WriteLine("----头部相邻交换");
            ////case-6 => 5
            //Console.WriteLine(doubleLinkedList.Head.Content);
            ////case-6 => 1
            //Console.WriteLine(doubleLinkedList.Head.Next.Content);
            //doubleLinkedList.Swap(firstNode, fifthNode);
            ////case-6 => 5
            //Console.WriteLine(doubleLinkedList.Head.Content);
            ////case-6' => 1
            //Console.WriteLine(doubleLinkedList.Head.Next.Content);

            //13,泛型集合
            foreach (var item in doubleLinkedList)
            {
                Console.WriteLine(item);
            }

            ////调用扩展方法Max()
            //DoubleLinkedList<int> Node = new DoubleLinkedList<int> ();
            //Node.Max();

            //一篇文章可以有多个评论
            Comment goodComment = new Comment { content = "好评" };
            Comment badComment = new Comment { content = "差评" };
            Article<string> article = new Article<string> { comment = new List<Comment> { goodComment, badComment } };

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

            Article<string> LifeArticle = new Article<string> { keyWords = new List<KeyWord>{ Csharp, SQL } };
            Article<string> StudyArticle = new Article<string> { keyWords = new List<KeyWord> { Csharp, SQL, Javascript } };

            Csharp.articles = new List<Article<string>> { LifeArticle, StudyArticle };




            Console.Read();
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
    class Bueaty
    {
        //internal readonly int Age;
        //internal int Height;
        private int Age;
        public Bueaty(int age)
        {

            Age = age;
        }
        //public int toBueaty
        //{
        //    get{ return Age; }

        //  //  set { Age = value; }
        //}
        public int toBueaty { get; private set; } = 100;
        //public Bueaty(int age, int height)
        //{
        //    Age = age;
        //    Height = height;
        //}

        //public int Bueatyheight(int height)
        //{
        //    Height = height;
        //    return Height;
        //}

    }
    class Date
    {
        internal DateTime date1 = new DateTime(2019, 3, 6);

        internal Date()
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

    class Beautyliu
    {
        private int _age;
        //internal int beauty
        //{
        //    get { return _age; }
        //    //set { _age = 20; }
        //}

        //internal int beauty { get;private set; }
        //internal int Age { get; set; } = 28;

        public int beauty
        {
            get => _age;
            //set => _age = 18;
            set { _age = 18; }
        }

        //public Beauty()
        //{

        //}
    }



}

