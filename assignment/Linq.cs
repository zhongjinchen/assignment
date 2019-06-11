using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Linq
    {
    }
    class Classmate
    {
        internal string name;
        internal int age;
        internal Teacher teacher;
    }
    class Teacher
    {
        internal string teachers;
        internal int age;
    }

   static class RecentlyPublic
    {
        internal static IEnumerable<T> recentlypublic<T>(this IEnumerable<T> source,Func<T,bool> action)
        {
            IList<T> ts=new List<T>();
            foreach (var item in source)
            {
                if (action(item))
                {
                    ts.Add(item);
                }
            }
            return ts;
        }
    }


}
