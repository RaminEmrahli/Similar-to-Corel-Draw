namespace MarketManagementSystem
{
    partial class FrmShopping
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShopping));
            toolStripCategories = new ToolStrip();
            tsDropDownBtnCategories = new ToolStripDropDownButton();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            labelSelectedCategory = new Label();
            toolStrip2 = new ToolStrip();
            pictureBoxSlider = new PictureBox();
            radioButton2 = new RadioButton();
            flowlyPanelBestSellers = new FlowLayoutPanel();
            labelBestSellers = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            txtSearchText = new TextBox();
            labelTotal = new Label();
            btnAddBasket = new Button();
            btnSearch = new Button();
            btnBack = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            toolStrip3 = new ToolStrip();
            label3 = new Label();
            label1 = new Label();
            btnContactUs = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            radioButton1 = new RadioButton();
            toolStripCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // toolStripCategories
            // 
            toolStripCategories.BackColor = Color.LawnGreen;
            toolStripCategories.Dock = DockStyle.None;
            toolStripCategories.Items.AddRange(new ToolStripItem[] { tsDropDownBtnCategories });
            toolStripCategories.LayoutStyle = ToolStripLayoutStyle.Table;
            toolStripCategories.Location = new Point(161, 99);
            toolStripCategories.Name = "toolStripCategories";
            toolStripCategories.ShowItemToolTips = false;
            toolStripCategories.Size = new Size(192, 37);
            toolStripCategories.TabIndex = 0;
            toolStripCategories.Text = "toolStrip1";
            // 
            // tsDropDownBtnCategories
            // 
            tsDropDownBtnCategories.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsDropDownBtnCategories.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tsDropDownBtnCategories.ForeColor = Color.White;
            tsDropDownBtnCategories.Image = (Image)resources.GetObject("tsDropDownBtnCategories.Image");
            tsDropDownBtnCategories.ImageTransparentColor = Color.Magenta;
            tsDropDownBtnCategories.Name = "tsDropDownBtnCategories";
            tsDropDownBtnCategories.Size = new Size(191, 34);
            tsDropDownBtnCategories.Text = "Məhsul kataloqu";
            tsDropDownBtnCategories.DropDownItemClicked += tsDropDownBtnCategories_DropDownItemClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(160, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 54);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Silver;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(160, 78);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(958, 1);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // labelSelectedCategory
            // 
            labelSelectedCategory.AutoSize = true;
            labelSelectedCategory.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSelectedCategory.Location = new Point(160, 171);
            labelSelectedCategory.Name = "labelSelectedCategory";
            labelSelectedCategory.Size = new Size(0, 30);
            labelSelectedCategory.TabIndex = 3;
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.BackColor = Color.Silver;
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip2.Location = new Point(161, 146);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(958, 1);
            toolStrip2.TabIndex = 4;
            toolStrip2.Text = "toolStrip2";
            // 
            // pictureBoxSlider
            // 
            pictureBoxSlider.Location = new Point(161, 216);
            pictureBoxSlider.Name = "pictureBoxSlider";
            pictureBoxSlider.Size = new Size(958, 238);
            pictureBoxSlider.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSlider.TabIndex = 5;
            pictureBoxSlider.TabStop = false;
            pictureBoxSlider.Click += pictureBoxSlider_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.ForeColor = Color.LawnGreen;
            radioButton2.Location = new Point(632, 428);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(13, 12);
            radioButton2.TabIndex = 7;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            radioButton2.Click += radioButton2_Click;
            // 
            // flowlyPanelBestSellers
            // 
            flowlyPanelBestSellers.Location = new Point(161, 494);
            flowlyPanelBestSellers.Name = "flowlyPanelBestSellers";
            flowlyPanelBestSellers.Size = new Size(958, 225);
            flowlyPanelBestSellers.TabIndex = 8;
            // 
            // labelBestSellers
            // 
            labelBestSellers.AutoSize = true;
            labelBestSellers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBestSellers.ForeColor = Color.FromArgb(64, 64, 64);
            labelBestSellers.Location = new Point(160, 470);
            labelBestSellers.Name = "labelBestSellers";
            labelBestSellers.Size = new Size(209, 21);
            labelBestSellers.TabIndex = 9;
            labelBestSellers.Text = "Ən çox satılan məhsullarımız";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 5000;
            timer2.Tick += timer2_Tick;
            // 
            // txtSearchText
            // 
            txtSearchText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchText.Location = new Point(356, 99);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.Size = new Size(637, 35);
            txtSearchText.TabIndex = 10;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.LawnGreen;
            labelTotal.Location = new Point(1057, 109);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(44, 25);
            labelTotal.TabIndex = 11;
            labelTotal.Text = "₼ 0";
            labelTotal.Click += label1_Click;
            // 
            // btnAddBasket
            // 
            btnAddBasket.BackgroundImage = (Image)resources.GetObject("btnAddBasket.BackgroundImage");
            btnAddBasket.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBasket.FlatStyle = FlatStyle.Flat;
            btnAddBasket.Location = new Point(1005, 99);
            btnAddBasket.Name = "btnAddBasket";
            btnAddBasket.Size = new Size(44, 35);
            btnAddBasket.TabIndex = 12;
            btnAddBasket.UseVisualStyleBackColor = true;
            btnAddBasket.Click += btnAddBasket_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(953, 101);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(33, 30);
            btnSearch.TabIndex = 13;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(37, 23);
            btnBack.TabIndex = 14;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(161, 793);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 47);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // toolStrip3
            // 
            toolStrip3.AutoSize = false;
            toolStrip3.BackColor = Color.Silver;
            toolStrip3.Dock = DockStyle.None;
            toolStrip3.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip3.Location = new Point(161, 776);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(958, 1);
            toolStrip3.TabIndex = 17;
            toolStrip3.Text = "toolStrip3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(161, 848);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 19;
            label3.Text = "*2266";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 867);
            label1.Name = "label1";
            label1.Size = new Size(256, 17);
            label1.TabIndex = 20;
            label1.Text = "Müştəri Xidmətləri 9:00-dan 20:00-a qədər";
            // 
            // btnContactUs
            // 
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactUs.ForeColor = Color.LawnGreen;
            btnContactUs.Location = new Point(161, 887);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(102, 35);
            btnContactUs.TabIndex = 21;
            btnContactUs.Text = "Əlaqə";
            btnContactUs.UseVisualStyleBackColor = true;
            btnContactUs.Click += btnContactUs_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(451, 793);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 22;
            label2.Text = "Alıcılara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 825);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 23;
            label4.Text = "FAQ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 845);
            label5.Name = "label5";
            label5.Size = new Size(170, 30);
            label5.TabIndex = 24;
            label5.Text = "Malların sifarişi və satış qaydası\r\nhaqqında razılaşma\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(667, 852);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 27;
            label6.Text = "Geri qaytarma şərtləri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(667, 825);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 26;
            label7.Text = "Çatdırılma və ödəniş";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(667, 793);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 25;
            label8.Text = "Məlumat";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(161, 930);
            label9.Name = "label9";
            label9.Size = new Size(196, 15);
            label9.TabIndex = 28;
            label9.Text = "2023 © Azerbaijan Supermarket LLC";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(823, 793);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 29);
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(898, 793);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 29);
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(971, 793);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 29);
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.White;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.ForeColor = Color.LawnGreen;
            radioButton1.Location = new Point(613, 428);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(13, 12);
            radioButton1.TabIndex = 32;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton1.Click += radioButton1_Click;
            // 
            // FrmShopping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1262, 751);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnContactUs);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(toolStrip3);
            Controls.Add(pictureBox2);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(btnAddBasket);
            Controls.Add(labelTotal);
            Controls.Add(txtSearchText);
            Controls.Add(labelBestSellers);
            Controls.Add(flowlyPanelBestSellers);
            Controls.Add(radioButton2);
            Controls.Add(pictureBoxSlider);
            Controls.Add(toolStrip2);
            Controls.Add(labelSelectedCategory);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(toolStripCategories);
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmShopping";
            Text = "FrmShopping";
            Load += FrmShopping_Load;
            toolStripCategories.ResumeLayout(false);
            toolStripCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripCategories;
        private ToolStripDropDownButton tsDropDownBtnCategories;
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private Label labelSelectedCategory;
        private ToolStrip toolStrip2;
        private PictureBox pictureBoxSlider;
        private RadioButton radioButton2;
        private FlowLayoutPanel flowlyPanelBestSellers;
        private Label labelBestSellers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private TextBox txtSearchText;
        private Label labelTotal;
        private Button btnAddBasket;
        private Button btnSearch;
        private Button btnBack;
        private System.Windows.Forms.Timer timer3;
        private PictureBox pictureBox2;
        private ToolStrip toolStrip3;
        private Label label3;
        private Label label1;
        private Button btnContactUs;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private RadioButton radioButton1;
    }
}