using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ImageFilter
    {
        public static Image ConvertToGrayscaleImage(Image image)
        {
            var bitmap = new Bitmap(image);

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    var gray = (pixel.R + pixel.G + pixel.B) / 3;
                    bitmap.SetPixel(x, y, Color.FromArgb(pixel.A, gray, gray, gray));
                }
            }

            return bitmap;
        }

        public static Image ConvertToBlackWhiteImage(Image image)
        {
            var bitmap = new Bitmap(image);

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    var c = (pixel.R + pixel.G + pixel.B) / 3 > 0x80 ? 0: 0xFF;
                    bitmap.SetPixel(x, y, Color.FromArgb(pixel.A, c, c, c));
                }
            }

            return bitmap;
        }
    }
}
