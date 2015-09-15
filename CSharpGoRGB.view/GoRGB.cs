using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//..
using CSharpGoRGB.logic;
using System.IO;

namespace CSharpGoRGB.view
{
    public partial class GoRGB : Form
    {
        public GoRGB()
        {
            InitializeComponent();
        }

        // Create new picture object
        Picture picture = new Picture();

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            // Load an image
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get file location
                string file = openFileDialog1.FileName;
                try
                {
                    // Create and set bitmap
                    Bitmap bitmap = new Bitmap(Image.FromFile(file));
                    // Scale Bitmap to fit in picturebox
                    bitmap = picture.ScaleBitmap(bitmap, pictureBox.Width, pictureBox.Height);
                    // Center picture using padding. Get paddings
                    picture.PaddingWidth = picture.GetPadding(bitmap.Width, pictureBox.Width);
                    picture.PaddingHeight = picture.GetPadding(bitmap.Height, pictureBox.Height);
                    // Reset padding to default. They were adding up before
                    pictureBox.Padding = new Padding(0, 0, 0, 0);
                    // Set padding to center picture
                    pictureBox.Padding = new Padding(picture.PaddingWidth, picture.PaddingHeight, 0, 0);
                    // Set bitmap
                    pictureBox.Image = bitmap;
                }
                catch (Exception)
                {
                    MessageBox.Show("File not found!", "Error");
                }
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Set RGB and Hex text
            SetRGBHex(e);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Check the mouse is held down
            if (e.Button == MouseButtons.Left)
            {
                // Set RGB and Hex text
                SetRGBHex(e);
            }
        }

        private void SetRGBHex(MouseEventArgs e)
        {
            Bitmap bitmap = null;
            try
            {
                // Get bitmap from array
                bitmap = picture.ArrayToBitmap(picture.BitmapArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitmap error!", "Error");
            }
            // Check there is a picture
            if (bitmap != null)
            {
                // Get pixel location - padding (padding isn't taken into account otherwise)
                picture.Position.X = e.X - picture.PaddingWidth;
                picture.Position.Y = e.Y - picture.PaddingHeight;
                // Get the colour
                picture.SetColor(picture.Position, bitmap);
                // Set RGB and Hex values/text
                txtboxRGB.Text = picture.ReturnRGB(picture.Colour);
                txtBoxHex.Text = picture.ReturnHex(picture.Colour);
                // Set sample colour
                pictureBoxSample.BackColor = picture.Colour;
            }
        }
    }
}
