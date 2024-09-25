namespace MarketManagementSystem
{
    partial class FrmAdminPanel
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
            tbPageOrders = new TabPage();
            dataGridOrders = new DataGridView();
            tbPageProducts = new TabPage();
            txtProductImage = new TextBox();
            txtProductCount = new TextBox();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            btnChooseImage = new Button();
            cmbBoxBrandsForProducts = new ComboBox();
            cmbBoxCategoriesForProducts = new ComboBox();
            labelBrand = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnAddProduct = new Button();
            dataGridProducts = new DataGridView();
            tbPageBrands = new TabPage();
            label3 = new Label();
            cmbBoxCategoriesForBrands = new ComboBox();
            btnBrandAdd = new Button();
            txtBrandName = new TextBox();
            label2 = new Label();
            dataGridBrands = new DataGridView();
            tbPageCategories = new TabPage();
            linkLabel1 = new LinkLabel();
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            label1 = new Label();
            dataGridCategories = new DataGridView();
            tabControl1 = new TabControl();
            tbPageMessage = new TabPage();
            dataGridMessages = new DataGridView();
            tbPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            tbPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            tbPageBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBrands).BeginInit();
            tbPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategories).BeginInit();
            tabControl1.SuspendLayout();
            tbPageMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMessages).BeginInit();
            SuspendLayout();
            // 
            // tbPageOrders
            // 
            tbPageOrders.Controls.Add(dataGridOrders);
            tbPageOrders.Location = new Point(4, 24);
            tbPageOrders.Name = "tbPageOrders";
            tbPageOrders.Size = new Size(710, 403);
            tbPageOrders.TabIndex = 3;
            tbPageOrders.Text = "Orders";
            tbPageOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridOrders
            // 
            dataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrders.Dock = DockStyle.Fill;
            dataGridOrders.Location = new Point(0, 0);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.RowTemplate.Height = 25;
            dataGridOrders.Size = new Size(710, 403);
            dataGridOrders.TabIndex = 0;
            // 
            // tbPageProducts
            // 
            tbPageProducts.Controls.Add(txtProductImage);
            tbPageProducts.Controls.Add(txtProductCount);
            tbPageProducts.Controls.Add(txtProductPrice);
            tbPageProducts.Controls.Add(txtProductName);
            tbPageProducts.Controls.Add(btnChooseImage);
            tbPageProducts.Controls.Add(cmbBoxBrandsForProducts);
            tbPageProducts.Controls.Add(cmbBoxCategoriesForProducts);
            tbPageProducts.Controls.Add(labelBrand);
            tbPageProducts.Controls.Add(label7);
            tbPageProducts.Controls.Add(label6);
            tbPageProducts.Controls.Add(label5);
            tbPageProducts.Controls.Add(label4);
            tbPageProducts.Controls.Add(btnAddProduct);
            tbPageProducts.Controls.Add(dataGridProducts);
            tbPageProducts.Location = new Point(4, 24);
            tbPageProducts.Name = "tbPageProducts";
            tbPageProducts.Size = new Size(710, 403);
            tbPageProducts.TabIndex = 2;
            tbPageProducts.Text = "Products";
            tbPageProducts.UseVisualStyleBackColor = true;
            // 
            // txtProductImage
            // 
            txtProductImage.Enabled = false;
            txtProductImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductImage.Location = new Point(97, 284);
            txtProductImage.Name = "txtProductImage";
            txtProductImage.Size = new Size(148, 29);
            txtProductImage.TabIndex = 18;
            // 
            // txtProductCount
            // 
            txtProductCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductCount.Location = new Point(66, 139);
            txtProductCount.Name = "txtProductCount";
            txtProductCount.Size = new Size(179, 29);
            txtProductCount.TabIndex = 15;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductPrice.Location = new Point(66, 90);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(179, 29);
            txtProductPrice.TabIndex = 14;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(66, 41);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(179, 29);
            txtProductName.TabIndex = 5;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(3, 284);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(88, 31);
            btnChooseImage.TabIndex = 17;
            btnChooseImage.Text = "Choose File";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // cmbBoxBrandsForProducts
            // 
            cmbBoxBrandsForProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxBrandsForProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxBrandsForProducts.FormattingEnabled = true;
            cmbBoxBrandsForProducts.Location = new Point(66, 237);
            cmbBoxBrandsForProducts.Name = "cmbBoxBrandsForProducts";
            cmbBoxBrandsForProducts.Size = new Size(179, 29);
            cmbBoxBrandsForProducts.TabIndex = 13;
            cmbBoxBrandsForProducts.Visible = false;
            // 
            // cmbBoxCategoriesForProducts
            // 
            cmbBoxCategoriesForProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategoriesForProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxCategoriesForProducts.FormattingEnabled = true;
            cmbBoxCategoriesForProducts.Location = new Point(66, 188);
            cmbBoxCategoriesForProducts.Name = "cmbBoxCategoriesForProducts";
            cmbBoxCategoriesForProducts.Size = new Size(179, 29);
            cmbBoxCategoriesForProducts.TabIndex = 12;
            cmbBoxCategoriesForProducts.SelectedIndexChanged += cmbBoxCategoriesForProducts_SelectedIndexChanged;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrand.Location = new Point(16, 249);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(44, 17);
            labelBrand.TabIndex = 11;
            labelBrand.Text = "Brand";
            labelBrand.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 200);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 10;
            label7.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 151);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 9;
            label6.Text = "Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 102);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 53);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Blue;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(170, 319);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 37);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dataGridProducts
            // 
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Location = new Point(265, 3);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.RowTemplate.Height = 25;
            dataGridProducts.Size = new Size(442, 392);
            dataGridProducts.TabIndex = 4;
            // 
            // tbPageBrands
            // 
            tbPageBrands.Controls.Add(label3);
            tbPageBrands.Controls.Add(cmbBoxCategoriesForBrands);
            tbPageBrands.Controls.Add(btnBrandAdd);
            tbPageBrands.Controls.Add(txtBrandName);
            tbPageBrands.Controls.Add(label2);
            tbPageBrands.Controls.Add(dataGridBrands);
            tbPageBrands.Location = new Point(4, 24);
            tbPageBrands.Name = "tbPageBrands";
            tbPageBrands.Padding = new Padding(3);
            tbPageBrands.Size = new Size(710, 403);
            tbPageBrands.TabIndex = 1;
            tbPageBrands.Text = "Brands";
            tbPageBrands.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1, 96);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 9;
            label3.Text = "CategoryName";
            // 
            // cmbBoxCategoriesForBrands
            // 
            cmbBoxCategoriesForBrands.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategoriesForBrands.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxCategoriesForBrands.FormattingEnabled = true;
            cmbBoxCategoriesForBrands.Location = new Point(107, 84);
            cmbBoxCategoriesForBrands.Name = "cmbBoxCategoriesForBrands";
            cmbBoxCategoriesForBrands.Size = new Size(132, 29);
            cmbBoxCategoriesForBrands.TabIndex = 8;
            // 
            // btnBrandAdd
            // 
            btnBrandAdd.BackColor = Color.Blue;
            btnBrandAdd.ForeColor = Color.White;
            btnBrandAdd.Location = new Point(164, 119);
            btnBrandAdd.Name = "btnBrandAdd";
            btnBrandAdd.Size = new Size(75, 37);
            btnBrandAdd.TabIndex = 7;
            btnBrandAdd.Text = "Add";
            btnBrandAdd.UseVisualStyleBackColor = false;
            btnBrandAdd.Click += btnBrandAdd_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrandName.Location = new Point(107, 43);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(132, 29);
            txtBrandName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // dataGridBrands
            // 
            dataGridBrands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBrands.Location = new Point(255, 5);
            dataGridBrands.Name = "dataGridBrands";
            dataGridBrands.RowTemplate.Height = 25;
            dataGridBrands.Size = new Size(447, 390);
            dataGridBrands.TabIndex = 4;
            // 
            // tbPageCategories
            // 
            tbPageCategories.Controls.Add(linkLabel1);
            tbPageCategories.Controls.Add(btnAddCategory);
            tbPageCategories.Controls.Add(txtCategoryName);
            tbPageCategories.Controls.Add(label1);
            tbPageCategories.Controls.Add(dataGridCategories);
            tbPageCategories.Location = new Point(4, 24);
            tbPageCategories.Name = "tbPageCategories";
            tbPageCategories.Padding = new Padding(3);
            tbPageCategories.Size = new Size(715, 404);
            tbPageCategories.TabIndex = 0;
            tbPageCategories.Text = "Categories";
            tbPageCategories.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(8, 360);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LogOut";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.Blue;
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(128, 85);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 37);
            btnAddCategory.TabIndex = 3;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(71, 41);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(132, 29);
            txtCategoryName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 53);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // dataGridCategories
            // 
            dataGridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategories.Location = new Point(272, 14);
            dataGridCategories.Name = "dataGridCategories";
            dataGridCategories.RowTemplate.Height = 25;
            dataGridCategories.Size = new Size(430, 381);
            dataGridCategories.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPageCategories);
            tabControl1.Controls.Add(tbPageBrands);
            tabControl1.Controls.Add(tbPageProducts);
            tabControl1.Controls.Add(tbPageOrders);
            tabControl1.Controls.Add(tbPageMessage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(723, 432);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tbPageMessage
            // 
            tbPageMessage.Controls.Add(dataGridMessages);
            tbPageMessage.Location = new Point(4, 24);
            tbPageMessage.Name = "tbPageMessage";
            tbPageMessage.Padding = new Padding(3);
            tbPageMessage.Size = new Size(710, 403);
            tbPageMessage.TabIndex = 4;
            tbPageMessage.Text = "Messages";
            tbPageMessage.UseVisualStyleBackColor = true;
            // 
            // dataGridMessages
            // 
            dataGridMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMessages.Dock = DockStyle.Fill;
            dataGridMessages.Location = new Point(3, 3);
            dataGridMessages.Name = "dataGridMessages";
            dataGridMessages.RowTemplate.Height = 25;
            dataGridMessages.Size = new Size(704, 397);
            dataGridMessages.TabIndex = 0;
            // 
            // FrmAdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 432);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdminPanel";
            Load += FrmAdminPanel_Load;
            tbPageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            tbPageProducts.ResumeLayout(false);
            tbPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            tbPageBrands.ResumeLayout(false);
            tbPageBrands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBrands).EndInit();
            tbPageCategories.ResumeLayout(false);
            tbPageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategories).EndInit();
            tabControl1.ResumeLayout(false);
            tbPageMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMessages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tbPageOrders;
        private DataGridView dataGridOrders;
        private TabPage tbPageProducts;
        private TextBox txtProductImage;
        private TextBox txtProductCount;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private Button btnChooseImage;
        private ComboBox cmbBoxBrandsForProducts;
        private ComboBox cmbBoxCategoriesForProducts;
        private Label labelBrand;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAddProduct;
        private DataGridView dataGridProducts;
        private TabPage tbPageBrands;
        private Label label3;
        private ComboBox cmbBoxCategoriesForBrands;
        private Button btnBrandAdd;
        private TextBox txtBrandName;
        private Label label2;
        private DataGridView dataGridBrands;
        private TabPage tbPageCategories;
        private Button btnAddCategory;
        private TextBox txtCategoryName;
        private Label label1;
        private DataGridView dataGridCategories;
        private TabControl tabControl1;
        private TabPage tbPageMessage;
        private DataGridView dataGridMessages;
        private LinkLabel linkLabel1;
    }
}