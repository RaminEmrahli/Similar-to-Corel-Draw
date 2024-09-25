namespace MarketManagementSystem
{
    partial class BasketCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketCard));
            pictureBox1 = new PictureBox();
            labelProductName = new Label();
            labelProductPrice = new Label();
            label3 = new Label();
            labelTotal = new Label();
            txtProductCount = new TextBox();
            label1 = new Label();
            btnMinus = new Button();
            btnPlus = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 16.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductName.Location = new Point(109, 37);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(0, 30);
            labelProductName.TabIndex = 1;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductPrice.Location = new Point(425, 35);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(29, 30);
            labelProductPrice.TabIndex = 2;
            labelProductPrice.Text = "₼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(425, 68);
            label3.Name = "label3";
            label3.Size = new Size(93, 13);
            label3.TabIndex = 3;
            label3.Text = "üçün qiymət pcs.";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(686, 40);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(29, 30);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "₼";
            // 
            // txtProductCount
            // 
            txtProductCount.Enabled = false;
            txtProductCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductCount.Location = new Point(594, 42);
            txtProductCount.Name = "txtProductCount";
            txtProductCount.Size = new Size(42, 29);
            txtProductCount.TabIndex = 5;
            txtProductCount.Text = "1";
            txtProductCount.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(602, 75);
            label1.Name = "label1";
            label1.Size = new Size(27, 13);
            label1.TabIndex = 6;
            label1.Text = "pcs.";
            // 
            // btnMinus
            // 
            btnMinus.BackgroundImage = (Image)resources.GetObject("btnMinus.BackgroundImage");
            btnMinus.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinus.Location = new Point(572, 51);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(18, 18);
            btnMinus.TabIndex = 7;
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackgroundImage = (Image)resources.GetObject("btnPlus.BackgroundImage");
            btnPlus.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlus.Location = new Point(642, 51);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(18, 18);
            btnPlus.TabIndex = 8;
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // BasketCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(label1);
            Controls.Add(txtProductCount);
            Controls.Add(labelTotal);
            Controls.Add(label3);
            Controls.Add(labelProductPrice);
            Controls.Add(labelProductName);
            Controls.Add(pictureBox1);
            Name = "BasketCard";
            Size = new Size(781, 109);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelProductName;
        private Label labelProductPrice;
        private Label label3;
        private Label labelTotal;
        private TextBox txtProductCount;
        private Label label1;
        private Button btnMinus;
        private Button btnPlus;
    }
}
