using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Bitmap bitmap = new Bitmap(200, 100))
            {
                try
                {
                    Captcha draw = new Captcha(200, 100, Color.Blue);
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



      

            Console.Read();
        }
        static void a(string a, params int[] b) { }

    }
}
