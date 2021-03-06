﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace assignment
{

    //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），他们： 
    //都有作者（Author）、标题（Title）和正文（Body） 
    //可以发布和被人点赞和踩
    //还可以被评论（Comment） 
    //请综合利用已学到的面向对象的知识在，完成上述类型建模

    //在泛型章节作业的基础上，观察一起帮的文章板块，以此为蓝本，补充声明： 
    //评论（Comment）类
    //评价（Appraise）类
    //关键字（Keyword）类
    //并构建以下关系： 

    //调用扩展方法Max()
    static class DoubleLinkedList
    {
        internal static void Max(this DoubleLinkedList<int> source)
        {
            Console.WriteLine("调用Max()方法");
        }
    }

    //协变，逆变 out/in
    interface IPeople<in T> { }
    class Man<T> : IPeople<T> { }
    class Clever { }
    class foolish : Clever { }
}
