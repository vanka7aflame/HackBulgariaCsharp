using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _03_MoreProblems
{
    class Program
    {
        public static void setNewPic(Bitmap bmp, string savePath)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int k = 0; k < bmp.Height; k++)
                {
                    Color pixel = bmp.GetPixel(i, k);
                    byte gray = (byte)(pixel.R * 0.33 + pixel.G * 0.33 + pixel.B * 0.33);
                    Color newPixel = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, k, newPixel);
                }
            }
            bmp.Save(savePath);
        }
        static void Main(string[] args)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(@"C:\vanka7a\VS Projects\HackBulgariaCsharp\Week 01\03 MoreProblems\03 MoreProblems\Panda.bmp");
            string savePath = @"C:\vanka7a\VS Projects\HackBulgariaCsharp\Week 01\03 MoreProblems\03 MoreProblems\newPanda.bmp";
            setNewPic(bmp, savePath);
        }
    }
}
