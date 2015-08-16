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
        // Fields? Properties?
        public Bitmap ImageBitmap { get; set; }
        public Vector2 Position { get; set; }
        public Color Colour { get; set; }
        public string RGB { get; set; }
        public string Hex { get; set; }
        public int PaddingWidth { get; set; }
        public int PaddingHeight { get; set; }

        // Constructor

        public Picture()
        {
            Position = new Vector2();
        }
        // Methods

        public void ScaleBitmap(Bitmap bitmap, int width, int height)
        {
            double scale = 1;
            // Check wheather to use width or height for scaling
            if (bitmap.Width > bitmap.Height)
            {
                // Get scale
                scale = bitmap.Width / width;
            }
            else if (bitmap.Width <= bitmap.Height)
            {
                // Get scale
                scale = bitmap.Height / height;
            }
            // Couldn't determine scale. Not scaling.
            else
            {
                scale = 1;
            }
            // Create a new bitmap using the scale
            this.ImageBitmap = new Bitmap(this.ImageBitmap, new Size((int)(bitmap.Width / scale), (int)(bitmap.Height / scale)));
        }

        public int GetPadding(int bitmap, int picturebox)
        {
            int padding = 0;
            // Check the image is larger than the picturebox
            if ((picturebox - bitmap) > 0)
            {
                // Subtract the width/height from the bitmap width/height, then divide by 2, to get the padding
                padding = (picturebox - bitmap) / 2;
            }

            return padding;
        }

        public void SetColor(Vector2 position, Bitmap bitmap)
        {
            try
            {
                // Set the colour using the X & Y from the mouse click
                this.Colour = bitmap.GetPixel(position.X, position.Y);
            }
            catch (Exception)
            {

            }
        }

        public string ReturnRGB(Color colour)
        {
            // Convert Color to RGB
            string red = colour.R.ToString();
            string green = colour.G.ToString();
            string blue = colour.B.ToString();

            return "#" + red + ", " + green + ", " + blue;
        }

        public string ReturnHex(Color colour)
        {
            // Convert Color to Hex
            string hex = "#" + colour.R.ToString("X2") + colour.G.ToString("X2") + colour.B.ToString("X2");
            return hex;
        }
    }
}
