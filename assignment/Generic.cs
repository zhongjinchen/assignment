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
        internal void AddAfter(DLinkNode<T> node)
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
        internal void Addbefore(DLinkNode<T> node)
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
                    AddAfter(b);
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
                    Addbefore(b);
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
                    AddAfter(a);
                    Remove(b);
                    Insert(c, b);
                    Tail = a;
                }

                else if (b.Previous == null)
                {
                    Remove(b);
                    Insert(a, b);
                    Remove(a);
                    Addbefore(a);
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
                    AddAfter(b);
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
