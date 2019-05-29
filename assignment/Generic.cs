using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Generic<TAge> where TAge : class, new()
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

    public class DLinkNode<T>
    {
        public DLinkNode<T> Previous;
        public DLinkNode<T> Next;
        public T Content;
    }
    class Node
    {

    }


    class DoubleLinkedList<T>
    {
        public T Head;
        public T Tail;
        public int Count;
        //AddAfter(T node, T beAdded)
        //{

        //}
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
