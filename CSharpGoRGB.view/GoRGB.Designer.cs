namespace CSharpGoRGB.view
{
    partial class GoRGB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtboxRGB = new System.Windows.Forms.TextBox();
            this.txtBoxHex = new System.Windows.Forms.TextBox();
            this.lblRGB = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBoxSample = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(325, 311);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(469, 300);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtboxRGB
            // 
            this.txtboxRGB.Location = new System.Drawing.Point(469, 108);
            this.txtboxRGB.Name = "txtboxRGB";
            this.txtboxRGB.Size = new System.Drawing.Size(100, 20);
            this.txtboxRGB.TabIndex = 2;
            // 
            // txtBoxHex
            // 
            this.txtBoxHex.Location = new System.Drawing.Point(469, 134);
            this.txtBoxHex.Name = "txtBoxHex";
            this.txtBoxHex.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHex.TabIndex = 3;
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(428, 111);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(30, 13);
            this.lblRGB.TabIndex = 4;
            this.lblRGB.Text = "RGB";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(428, 137);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(26, 13);
            this.lblHex.TabIndex = 5;
            this.lblHex.Text = "Hex";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Miramonte", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeading.Location = new System.Drawing.Point(425, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(153, 49);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "GoRGB";
            // 
            // pictureBoxSample
            // 
            this.pictureBoxSample.Location = new System.Drawing.Point(481, 206);
            this.pictureBoxSample.Name = "pictureBoxSample";
            this.pictureBoxSample.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxSample.TabIndex = 7;
            this.pictureBoxSample.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg; *.jpeg; *.png";
            // 
            // GoRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 335);
            this.Controls.Add(this.pictureBoxSample);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.txtBoxHex);
            this.Controls.Add(this.txtboxRGB);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "GoRGB";
            this.Text = "GoRGB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtboxRGB;
        private System.Windows.Forms.TextBox txtBoxHex;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBoxSample;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

