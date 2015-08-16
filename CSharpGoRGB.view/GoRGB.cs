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

        Picture picture = new Picture();

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    Image image = Image.FromFile(file);
                    picture.ImageBitmap = new Bitmap(image);
                    picture.ScaleBitmap(picture.ImageBitmap, pictureBox.Width, pictureBox.Height);
                    picture.GetPaddingWidth(picture.ImageBitmap, pictureBox.Width);
                    picture.GetPaddingHeight(picture.ImageBitmap, pictureBox.Height);
                    // Reset padding to default. They were adding up before
                    pictureBox.Padding = new Padding(0, 0, 0, 0);
                    pictureBox.Padding = new Padding(picture.PaddingWidth, picture.PaddingHeight, 0, 0);
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
            SetRGBHex(e);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetRGBHex(e);
            }
        }

        private void SetRGBHex(MouseEventArgs e)
        {
            picture.Position.X = e.X - picture.PaddingWidth;
            picture.Position.Y = e.Y - picture.PaddingHeight;

            picture.SetColor(picture.Position, picture.ImageBitmap);

            txtboxRGB.Text = picture.ReturnRGB(picture.Colour);
            txtBoxHex.Text = picture.ReturnHex(picture.Colour);

            pictureBoxSample.BackColor = picture.Colour;
        }
    }
}
