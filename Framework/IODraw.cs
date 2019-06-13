using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class IODraw
    {
        #region 绘图
        #region 练习
        ////Bitmap image = new Bitmap(200, 100);
        ////Graphics g = Graphics.FromImage(image);
        ////g.Clear(Color.AntiqueWhite);
        ////g.DrawLine(new Pen(Color.Black, 1), new Point(30, 20), new Point(100, 80));
        ////g.DrawString("hello", new Font("宋体", 32), new SolidBrush(Color.BlueViolet), new PointF(40, 25));
        ////image.SetPixel(190, 50, Color.Black);
        ////image.Save(@"C:\17bang\Hello.jpg", ImageFormat.Jpeg); 
        #endregion

        #region 作业

        ////参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含： 
        ////随机字符串
        ////混淆用的各色像素点
        ////混淆用的直线（或曲线）

        public static void identifyingCode()
        {
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            Random random = new Random();

            string str = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string firstPlaceStr = str.Substring(random.Next(str.Length), 1);
            string scondPlaceStr = str.Substring(random.Next(str.Length), 1);
            string thirdPlaceStr = str.Substring(random.Next(str.Length), 1);
            string fourthPlaceStr = str.Substring(random.Next(str.Length), 1);

            g.DrawString($"{firstPlaceStr}{scondPlaceStr}{thirdPlaceStr}{fourthPlaceStr}", new Font("宋体", 36), new SolidBrush(Color.Blue), new PointF(40, 25));
            for (int i = 0; i < 80; i++)
            {
                int x1 = random.Next(200);
                int y1 = random.Next(100);
                int x2 = random.Next(200);
                int y2 = random.Next(100);

                g.DrawLine(new Pen(Color.FromArgb(random.Next()), 1), new Point(x1, y1), new Point(x2, x2));

            }
            for (int i = 0; i < 1000; i++)
            {

                int x = random.Next(200);
                int y = random.Next(100);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));

            }
            image.Save(@"C:\17bang\homework.jpg", ImageFormat.Jpeg);


        }
        
        #endregion
        #endregion

    }
}
