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
                    // Create image from file location
                    Image image = Image.FromFile(file);
                    // Create and set bitmap
                    picture.ImageBitmap = new Bitmap(image);
                    // Scale Bitmap to fit in picturebox
                    picture.ScaleBitmap(picture.ImageBitmap, pictureBox.Width, pictureBox.Height);
                    // Center picture using padding. Get paddings
                    picture.PaddingWidth = picture.GetPadding(picture.ImageBitmap.Width, pictureBox.Width);
                    picture.PaddingHeight = picture.GetPadding(picture.ImageBitmap.Height, pictureBox.Height);
                    // Reset padding to default. They were adding up before
                    pictureBox.Padding = new Padding(0, 0, 0, 0);
                    // Set padding to center picture
                    pictureBox.Padding = new Padding(picture.PaddingWidth, picture.PaddingHeight, 0, 0);
                    // Set bitmap
                    pictureBox.Image = picture.ImageBitmap;
                }
                catch (Exception)
                {
                    MessageBox.Show("File not found!", "Error");
                }
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Check there is a picture
            if (picture.ImageBitmap != null)
            {
                // Set RGB and Hex text
                SetRGBHex(e);
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Check the mouse is held down
            if (e.Button == MouseButtons.Left)
            {
                // Check there is a picture
                if (picture.ImageBitmap != null)
                {
                    // Set RGB and Hex text
                    SetRGBHex(e);
                }
            }
        }

        private void SetRGBHex(MouseEventArgs e)
        {
            // Get pixel location - padding (padding isn't taken into account otherwise)
            picture.Position.X = e.X - picture.PaddingWidth;
            picture.Position.Y = e.Y - picture.PaddingHeight;
            // Get the colour
            picture.SetColor(picture.Position, picture.ImageBitmap);
            // Set RGB and Hex values/text
            txtboxRGB.Text = picture.ReturnRGB(picture.Colour);
            txtBoxHex.Text = picture.ReturnHex(picture.Colour);
            // Set sample colour
            pictureBoxSample.BackColor = picture.Colour;
        }
    }
}
