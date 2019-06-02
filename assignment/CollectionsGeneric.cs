using System;
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
    //一篇文章可以有多个评论
    //一个评论必须有一个它所评论的文章
    //每个文章和评论都有一个评价
    //一篇文章可以有多个关键字，一个关键字可以对应多篇文章

    class Problem<T>
    {
        internal T Author;
        internal T Title;
        internal T Body;
        internal void Pubilc()
        {
        }
        internal void Agree()
        {
        }
        internal void Disagree()
        {
        }
        internal void Comment()
        {
        }
    }
    class Article<T>
    {
        internal T Author;
        internal T Title;
        internal T Body;
        internal void Pubilc()
        {
        }
        internal void agree()
        {
        }
        internal void Disagree()
        {
        }
        internal void Comment()
        {
        }
    }
    class Suggest<T>
    {
        internal T Author;
        internal T Title;
        internal T Body;
        internal void Pubilc()
        {
        }
        internal void agree()
        {
        }
        internal void Disagree()
        {
        }
        internal void Comment()
        {
        }
    }
    class Comment { }
    class Appraise { }
    class KeyWord { }
    
}
