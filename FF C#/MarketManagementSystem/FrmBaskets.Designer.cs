namespace MarketManagementSystem
{
    partial class FrmBaskets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaskets));
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            panel1 = new Panel();
            btnOrder = new Button();
            labelWarning = new Label();
            labelTotal = new Label();
            label1 = new Label();
            btnResetBasket = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            flwPanelBaskets = new FlowLayoutPanel();
            label4 = new Label();
            timerForOrder = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(52, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 54);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(52, 68);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(781, 10);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(labelWarning);
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(51, 465);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 80);
            panel1.TabIndex = 6;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.LawnGreen;
            btnOrder.Enabled = false;
            btnOrder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(642, 14);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(136, 48);
            btnOrder.TabIndex = 14;
            btnOrder.Text = "Sifariş verin";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWarning.Location = new Point(178, 29);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(283, 21);
            labelWarning.TabIndex = 13;
            labelWarning.Text = "Minimum sifariş məbləği 30₼ olmalıdır\r\n";
            labelWarning.Visible = false;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.Black;
            labelTotal.Location = new Point(79, 28);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(41, 25);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "₼ 0";
            labelTotal.Click += labelTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Cəmi";
            // 
            // btnResetBasket
            // 
            btnResetBasket.FlatStyle = FlatStyle.Flat;
            btnResetBasket.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetBasket.ForeColor = Color.LawnGreen;
            btnResetBasket.Location = new Point(731, 85);
            btnResetBasket.Name = "btnResetBasket";
            btnResetBasket.Size = new Size(102, 35);
            btnResetBasket.TabIndex = 8;
            btnResetBasket.Text = "Səbəti sıfırla";
            btnResetBasket.UseVisualStyleBackColor = true;
            btnResetBasket.Click += btnResetBasket_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // flwPanelBaskets
            // 
            flwPanelBaskets.AutoScroll = true;
            flwPanelBaskets.BackColor = Color.White;
            flwPanelBaskets.Location = new Point(51, 126);
            flwPanelBaskets.Name = "flwPanelBaskets";
            flwPanelBaskets.Size = new Size(781, 347);
            flwPanelBaskets.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 93);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 7;
            label4.Text = "Səbət";
            // 
            // timerForOrder
            // 
            timerForOrder.Interval = 2000;
            timerForOrder.Tick += timerForOrder_Tick;
            // 
            // FrmBaskets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 571);
            Controls.Add(flwPanelBaskets);
            Controls.Add(btnResetBasket);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBaskets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Səbətim";
            FormClosed += FrmBaskets_FormClosed;
            Load += FrmBaskets_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private Panel panel1;
        private Label label1;
        private Button btnOrder;
        private Label labelWarning;
        private Label labelTotal;
        private Button btnResetBasket;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flwPanelBaskets;
        private Label label4;
        private System.Windows.Forms.Timer timerForOrder;
    }
}