namespace MarketManagementSystem
{
    partial class ProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            pictureBoxProduct = new PictureBox();
            btnAddToBasket = new Button();
            labelProductPrice = new Label();
            labelProductName = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.ImageLocation = "";
            pictureBoxProduct.Location = new Point(24, 15);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(224, 123);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            // 
            // btnAddToBasket
            // 
            btnAddToBasket.BackgroundImage = (Image)resources.GetObject("btnAddToBasket.BackgroundImage");
            btnAddToBasket.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddToBasket.Location = new Point(101, 158);
            btnAddToBasket.Name = "btnAddToBasket";
            btnAddToBasket.Size = new Size(126, 50);
            btnAddToBasket.TabIndex = 1;
            btnAddToBasket.UseVisualStyleBackColor = true;
            btnAddToBasket.Click += btnAddToBasket_Click;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductPrice.Location = new Point(24, 168);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(21, 20);
            labelProductPrice.TabIndex = 2;
            labelProductPrice.Text = "₼";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductName.Location = new Point(10, 130);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(0, 25);
            labelProductName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(24, 193);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 4;
            label3.Text = "1əd";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label3);
            Controls.Add(labelProductName);
            Controls.Add(labelProductPrice);
            Controls.Add(btnAddToBasket);
            Controls.Add(pictureBoxProduct);
            Name = "ProductCard";
            Size = new Size(268, 225);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProduct;
        private Button btnAddToBasket;
        private Label labelProductPrice;
        private Label labelProductName;
        private Label label3;
    }
}
