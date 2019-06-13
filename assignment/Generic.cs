using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Generic<TAge> where TAge : class, new()
    {
        public TAge Age;
        public Generic()
        {

        }
        public Generic(TAge age)
        {
            Age = age;
        }
    }

    class Call
    {
        public static void call()
        {
            #region 双向链表
            ////12，----双向链表
            ////----在后面添加节点
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
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
        }
    }

    //  用泛型实现一个类：双向链表节点DLinkNode<T>，包含以下几个属性： 
    //DLinkNode<T> Previous
    //DLinkNode<T> Next
    //T Content
    //创建一个类：“双向链表”（DoubleLinkedList<T>），包含以下属性方法：
    //T Head：第一个节点
    //T Tail：最后一个节点
    //int Count：共有多少个节点
    ////TODO: 索引this[n] 获得第n个节点
    //AddAfter(T node, T beAdded)：在beAdded之后添加节点node
    //Remove(T node)：删除链表中的node节点
    //Swap(T a, T b)：交换a节点和b节点的位置

    //链表节点
    public class DLinkNode<T>
    {
        public DLinkNode<T> Previous;
        public DLinkNode<T> Next;
        public T Content { get; set; }
    }

    //----双向链表
    class DoubleLinkedList<T> : IEnumerable<T>
    {
        internal int _count;
        public  DLinkNode<T> Head;
        public DLinkNode<T> Tail;
        internal int Count { get { return _count; } /*set;*/ }

        //----在最后面添加节点
        internal void AddOnTail(DLinkNode<T> node)
        {
            if (_count == 0)
            {
                Head = node;
            }
            else
            {
                DLinkNode<T> oldTail = Tail;
                oldTail.Next = node;
                node.Previous = oldTail;

            }
            Tail = node;
            _count++;
        }

        // ----在最前面添加节点
        internal void AddOnHead(DLinkNode<T> node)
        {
            if (_count == 0)
            {
                Tail = node;
            }
            else
            {
                DLinkNode<T> oldHead = Head;
                oldHead.Previous = node;
                node.Next = oldHead;
            }
            Head = node;
            _count++;
        }

        //-----删除节点
        internal void Remove(DLinkNode<T> node)
        {
            if (node.Previous == null && node.Next != null)
            {
                Head = node.Next;

                node.Next.Previous = null;
                node.Next = null;
            }
            else if (node.Next == null && node.Previous != null)
            {
                Tail = node.Previous;
                node.Previous.Next = null;
                node.Previous = null;
            }
            else if (node.Previous == null && node.Next == null)
            {
                node = null;
                Head = null;
                Tail = null;
            }
            else
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;

                node.Previous = null;
                node.Next = null;
            }
            _count--;
        }

        //----插入节点
        internal void Insert(DLinkNode<T> previousNode, DLinkNode<T> node)
        {
            if (previousNode.Next == null)
            {
                Console.WriteLine("请使用AddAfter()方法");
            }
            else
            {

                previousNode.Next.Previous = node;
                node.Next = previousNode.Next;
                previousNode.Next = node;
                node.Previous = previousNode;

            }
            _count++;

        }

        //----交换节点
        internal void Swap(DLinkNode<T> a, DLinkNode<T> b)
        {
            if (a.Next == b)
            {
                if (a.Previous == null && b.Next != null)
                {
                    a.Next = b.Next;
                    b.Next.Previous = a;
                    b.Previous = null;
                    b.Next = a;
                    a.Previous = b;
                    Head = b;

                }
                else if (a.Previous != null && b.Next == null)
                {
                    b.Next = a;
                    a.Previous.Next = b;

                    b.Previous = a.Previous;
                    a.Next = null;
                    a.Previous = b;

                    Tail = a;
                }
                else if (a.Previous == null && b.Next == null)
                {
                    a.Previous = b;
                    a.Next = null;
                    b.Next = a;
                    b.Previous = null;
                    Head = b;
                    Head = a;
                }
                else
                {
                    a.Next = b.Next;
                    b.Next.Previous = a;
                    DLinkNode<T> c = a.Previous;
                    a.Previous = b;
                    b.Next = a;
                    b.Previous = c;
                    c.Next = b;
                }
            }
            else if (a.Previous == b)
            {
                if (b.Previous == null && a.Next != null)
                {
                    Remove(b);
                    Insert(a, b);
                    Head = a;
                }
                else if (b.Previous != null && a.Next == null)
                {
                    Remove(a);
                    Insert(b.Previous, a);
                    Tail = b;
                }
                else if (b.Previous == null && a.Next == null)
                {
                    Remove(b);
                    AddOnTail(b);
                    Head = a;
                    Tail = b;
                }
                else
                {
                    Remove(b);
                    Insert(a, b);

                }
            }
            else
            {
                if (a.Previous == null)
                {

                    Remove(a);
                    Insert(b, a);
                    Remove(b);
                    AddOnHead(b);
                    Head = b;
                    if (a.Next == null)
                    {
                        Tail = a;
                    }
                    else
                    {

                    }
                }
                else if (a.Previous != null && b.Next == null)
                {
                    DLinkNode<T> c = a.Previous;
                    Remove(a);
                    AddOnTail(a);
                    Remove(b);
                    Insert(c, b);
                    Tail = a;
                }

                else if (b.Previous == null)
                {
                    Remove(b);
                    Insert(a, b);
                    Remove(a);
                    AddOnHead(a);
                    Head = a;
                    if (a.Next == null)
                    {
                        Tail = b;
                    }
                }
                else if (b.Previous != null && a.Next == null)
                {
                    DLinkNode<T> c = b.Previous;
                    Remove(b);
                    AddOnTail(b);
                    Remove(a);
                    Insert(c, a);
                    Tail = b;
                }
                else
                {
                    DLinkNode<T> Previous = a.Previous;
                    Remove(a);
                    Insert(b, a);
                    Remove(b);
                    Insert(Previous, b);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        class Enumerator : IEnumerator<T>
        {
       
            private DLinkNode<T> _current;
            private DoubleLinkedList<T> _dlnodes;
            public Enumerator(DoubleLinkedList<T> dlnodes)
            {
                _dlnodes = dlnodes;
               
            }

            public T Current
            {
                get
                {
                    return _current.Content;
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (_current == null)
                {
                    _current = _dlnodes.Head;
                }
                else
                {
                    _current = _current.Next;
                }

                return _current != null;

            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }










    //-----笔记
    interface ICode { }
    internal class javascript { }
    internal class Major { }
    internal class SQL : Major { }
    internal class Person<T> where T : Major { }
    //internal class Person<T> where T: SQL { }  仅仅是Type parameter不同，不算是不同的泛型类

    internal class Teacher<T> : Person<T> where T : Major { }
    internal class littleTeacher<T> : Person<T> where T : SQL { }

    //错误演示:子类（bigTeacher）的类型约束只能是父类（Person）
    //的类型约束(Major)及其子类（SQL）
    //internal class bigTeacher<T> : Person<T> where T : javascript { }

    //Teacher<T>和Teacher有没有什么关系？

    internal class Student : Person<Major>, ICode { }
    //internal class GoodStudent : Teacher { }




}
