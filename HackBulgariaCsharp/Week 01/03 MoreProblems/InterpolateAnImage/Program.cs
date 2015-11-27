using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InterpolateAnImage
{
    class Program
    {
        public static void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
        {
            Bitmap newBitmap = new Bitmap(newSize.Width, newSize.Height);
            float aspectW = (float)(newSize.Width - 1) / (bitmap.Width - 1);
            float aspectH = (float)(newSize.Height - 1) / (bitmap.Height - 1);
            for (int i = 0; i < newBitmap.Width; i++)
            {
                for (int k = 0; k < newBitmap.Height; k++)
                {
                    Color newPixel = bitmap.GetPixel((int)Math.Round((float)i / aspectW),
                        (int)Math.Round((float)k / aspectH));
                    newBitmap.SetPixel(i, k, newPixel);
                }
            }
            newBitmap.Save(savePath);
        }
        static void Main(string[] args)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(@"C:\vanka7a\VS Projects\HackBulgariaCsharp\Week 01\03 MoreProblems\03 MoreProblems\Panda.bmp");
            string savePath = @"C:\vanka7a\VS Projects\HackBulgariaCsharp\Week 01\03 MoreProblems\InterpolateAnImage\ResizedPanda.bmp";
            Size newSize = new Size(1000, 500);
            ResampleImage(bmp, newSize, savePath);
        }
    }
}
