using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Bitmap bitmap = new Bitmap(80, 40))
            {
                try
                {
                    Captcha draw = new Captcha(100, 50, Color.Blue);
                    Bitmap image=draw.Get();
                    image.Save(@"C:\17bang\homework.jpg", ImageFormat.Jpeg); 
                  
                }
                catch (StringColorErrorException e)
                {
                    Console.WriteLine("字符串颜色不能为白色");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("线超出界限");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                }
            }

            //作业： 
            //重构之前的验证码作业： 
            //创建一个新的前台线程（Thread），在这个线程上运行生成随机字符串的代码
            //在一个任务（Task）中生成画布
            //使用生成的画布，用两个任务完成： 
            //在画布上添加干扰线条
            //在画布上添加干扰点
            //将生成的验证码图片异步的存入文件
            //能捕获抛出的若干异常，并相应的处理
            //以上作业，需要在控制台输入线程和Task的Id，以演示异步并发的运行。



            Console.Read();
        }
        static void a(string a, params int[] b) { }

    }
}
