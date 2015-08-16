using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//..
using System.Drawing;

namespace CSharpGoRGB.logic
{
    public class Picture
    {
        public Bitmap ImageBitmap { get; set; }
        public Vector2 Position { get; set; }
        public Color Colour { get; set; }
        public string RGB { get; set; }
        public string Hex { get; set; }
        public int PaddingWidth { get; set; }
        public int PaddingHeight { get; set; }

        public Picture()
        {
            Position = new Vector2();
        }

        public void ScaleBitmap(Bitmap bitmap, int width, int height)
        {
            double scale = 1;

            if (bitmap.Width > bitmap.Height)
            {
                scale = bitmap.Width / width;
            }
            else if (bitmap.Width <= bitmap.Height)
            {
                scale = bitmap.Height / height;
            }
            else
            {
                scale = 1;
            }

            this.ImageBitmap = new Bitmap(this.ImageBitmap, new Size((int)(bitmap.Width / scale), (int)(bitmap.Height / scale)));
        }

        public void GetPaddingWidth(Bitmap bitmap, int width)
        {
            if ((width - bitmap.Width) > 0)
            {
                this.PaddingWidth = (width - bitmap.Width) / 2;
            }
        }

        public void GetPaddingHeight(Bitmap bitmap, int height)
        {
            if ((height - bitmap.Height) > 0)
            {
                PaddingHeight = (height - bitmap.Height) / 2;
            }
        }

        public void SetColor(Vector2 position, Bitmap bitmap)
        {
            try
            {
                this.Colour = bitmap.GetPixel(position.X, position.Y);
            }
            catch (Exception)
            {

            }
        }

        public string ReturnRGB(Color colour)
        {
            string red = colour.R.ToString();
            string green = colour.G.ToString();
            string blue = colour.B.ToString();

            return "#" + red + ", " + green + ", " + blue;
        }

        public string ReturnHex(Color colour)
        {
            string hex = "#" + colour.R.ToString("X2") + colour.G.ToString("X2") + colour.B.ToString("X2");
            return hex;
        }
    }
}
