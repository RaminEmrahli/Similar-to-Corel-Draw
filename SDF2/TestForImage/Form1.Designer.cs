namespace TestForImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            txtFileName = new TextBox();
            btnFileChoose = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(56, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(81, 287);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(388, 23);
            txtFileName.TabIndex = 1;
            // 
            // btnFileChoose
            // 
            btnFileChoose.Location = new Point(475, 287);
            btnFileChoose.Name = "btnFileChoose";
            btnFileChoose.Size = new Size(129, 23);
            btnFileChoose.TabIndex = 2;
            btnFileChoose.Text = "Choose File";
            btnFileChoose.UseVisualStyleBackColor = true;
            btnFileChoose.Click += btnFileChoose_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 398);
            Controls.Add(btnFileChoose);
            Controls.Add(txtFileName);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtFileName;
        private Button btnFileChoose;
        private ImageList imageList1;
    }
}