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

        //////参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含： 
        //////随机字符串
        //////混淆用的各色像素点
        //////混淆用的直线（或曲线）

        ////作业： 
        ////将生成验证码的代码拆分成若干个方法，并为其添加异常机制，要求能够： 
        ////显式的抛出一个自定义异常
        ////捕获并包裹一个被抛出的异常，记入日志文件，然后再次抛出
        ////根据不同的异常，给用户相应的友好的异常提示
        ////使用using释放文件资源


        //public void CreateString(Random random, Graphics g, Color color)
        //{
        //    if (color == Color.White)
        //    {
        //        throw new StringColorErrorException("颜色错误");
        //    }
        //    else
        //    {
        //        string str = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        //        string firstPlaceStr = str.Substring(random.Next(str.Length), 1);
        //        string scondPlaceStr = str.Substring(random.Next(str.Length), 1);
        //        string thirdPlaceStr = str.Substring(random.Next(str.Length), 1);
        //        string fourthPlaceStr = str.Substring(random.Next(str.Length), 1);
        //        g.DrawString($"{firstPlaceStr}{scondPlaceStr}{thirdPlaceStr}" +
        //        $"{fourthPlaceStr}", new Font("宋体", 36), new SolidBrush(color), new PointF(40, 25));
        //    }

        //}
        //public void CreateLine(Random random, Graphics g, int x, int y, Color color)
        //{
        //    if (x > 200 || y > 100)
        //    {
        //        throw new ArgumentOutOfRangeException();
        //    }
        //    try
        //    {
        //        CreateString(random, g, color);
        //    }
        //    catch (Exception e)
        //    {
        //        File.AppendAllText("C:\\17bang\\xl\\SCE", Environment.NewLine
        //            + Environment.NewLine + e.ToString());
        //        throw new StringColorErrorException("");
        //    }
        //    for (int i = 0; i < 80; i++)
        //    {
        //        int x1 = random.Next(x);
        //        int y1 = random.Next(y);
        //        int x2 = random.Next(x);
        //        int y2 = random.Next(y);

        //        g.DrawLine(new Pen(Color.FromArgb(random.Next()), 1),
        //            new Point(x1, y1), new Point(x2, x2));

        //    }
        //}

        //public void CreatePoint(Random random, Bitmap image, int X, int Y, Color color)
        //{
        //    Graphics g = Graphics.FromImage(image);
        //    g.Clear(Color.White);
        //    try
        //    {
        //        CreateLine(random, g, X, Y, color);
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        File.AppendAllText("C:\\17bang\\xl\\IORE", Environment.NewLine
        //            + Environment.NewLine + e.ToString());
        //        throw new ArgumentOutOfRangeException("超出界限", e);
        //    }
        //    for (int i = 0; i < 1000; i++)
        //    {

        //        int x = random.Next(200);
        //        int y = random.Next(100);
        //        image.SetPixel(x, y, Color.FromArgb(random.Next()));

        //    }
        //}
        //public void conserve(int X, int Y, Color color)
        //{
        //    Random random = new Random();
        //    Bitmap image = new Bitmap(200, 100);

        //    CreatePoint(random, image, X, Y, color);

        //    image.Save(@"C:\17bang\homework.jpg", ImageFormat.Jpeg);
        //}

        #endregion
        #endregion
    }
    class Captcha
    {
        private Random random;
        private Bitmap image;
        private Graphics g;
        private string path;
        private int Width;
        private int Height;
        private Color StringColor { get; }
        private const string str = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        public Captcha(int width, int height, Color stringColor)
        {
            Width = width;
            Height = height;
            random = new Random();

            StringColor = stringColor;
        }

        public Bitmap createCanvas()
        {
            return new Bitmap(Width, Height);
        }

        internal Bitmap Get()
        {
            try
            {
                Task<Bitmap> createCanvasTask = Task<Bitmap>.Run(() => createCanvas());
                createCanvasTask.Wait();
                image = createCanvasTask.Result;
                g = Graphics.FromImage(image);
                setbackground();
                Thread Drawcode = new Thread(new ThreadStart(() => { drawcode(g); }));
                Drawcode.Start();
               
                addNoise();
            }
            catch (Exception e)
            {
                File.AppendAllText("C:\\17bang\\xl\\SCE.txt",
                    Environment.NewLine + e.ToString()
                    + Environment.NewLine
                    + Environment.NewLine);
                throw new StringColorErrorException("");
            }
            return image;
        }

        private void addNoise()
        {

            try
            {
                Task AddLineTask = Task.Run(()=> { addLine(g); });
                //AddLineTask.Wait();
                //Task AddPointTask = Task.Run(()=> { addPoint(); });
                AddLineTask.ContinueWith((x) => { addPoint(); });
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                File.AppendAllText
                (
                    "C:\\17bang\\xl\\IORE.txt",
                    Environment.NewLine + e.ToString()
                    + Environment.NewLine
                    + Environment.NewLine
                 );

                throw new ArgumentOutOfRangeException("超出界限", e);
            }

        }

        //添加底色方法
        private void setbackground()
        {
            g.Clear(Color.White);

        }
        ////保存到文件方法
        //public void Save(string path)
        //{
        //    image.Save(path,ImageFormat.Jpeg);
        //}
        //字符串（验证码）方法
        public void drawcode(Graphics g)
        {
            if (StringColor == Color.White)
            {
                throw new StringColorErrorException("颜色错误");
            }
            else
            {
                
                string firstPlaceStr = str.Substring(random.Next(str.Length), 1);
                string scondPlaceStr = str.Substring(random.Next(str.Length), 1);
                string thirdPlaceStr = str.Substring(random.Next(str.Length), 1);
                string fourthPlaceStr = str.Substring(random.Next(str.Length), 1);
                g.DrawString
               (
                    $"{firstPlaceStr}{scondPlaceStr}{thirdPlaceStr}" +
                    $"{fourthPlaceStr}",
                    new Font("宋体", 36),
                    new SolidBrush(StringColor),
                    new PointF(40, 25)
                );
            }

        }
        //造线方法
        private void addLine(Graphics g)
        {
            if (image.Width > 200 || image.Height > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = 0; i < 80; i++)
            {
                int x1 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int x2 = random.Next(image.Width);
                int y2 = random.Next(image.Height);

                g.DrawLine(new Pen(Color.FromArgb(random.Next()), 1),
                    new Point(x1, y1), new Point(x2, x2));

            }
        }
        //造点方法点
        private void addPoint()
        {
            for (int i = 0; i < 1000; i++)
            {
                int x = random.Next(200);
                int y = random.Next(100);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }
        }
    }

    //自定义异常
    public class StringColorErrorException : Exception
    {
        public StringColorErrorException(string message) : base(message)
        {
        }
    }
}
