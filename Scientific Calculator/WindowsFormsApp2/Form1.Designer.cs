namespace WindowsFormsApp2
{
    partial class Calculator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1Screen = new System.Windows.Forms.TextBox();
            this.buttonDeleteHistory = new System.Windows.Forms.Button();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSHistory = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonM_Minus = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonSDelete = new System.Windows.Forms.Button();
            this.buttonSPlusMinus = new System.Windows.Forms.Button();
            this.buttonSPercent = new System.Windows.Forms.Button();
            this.buttonSSQRT = new System.Windows.Forms.Button();
            this.buttonSFormula = new System.Windows.Forms.Button();
            this.buttonSPoint = new System.Windows.Forms.Button();
            this.buttonS0 = new System.Windows.Forms.Button();
            this.buttonSEqual = new System.Windows.Forms.Button();
            this.buttonSMultiply = new System.Windows.Forms.Button();
            this.buttonSDivide = new System.Windows.Forms.Button();
            this.buttonSMinus = new System.Windows.Forms.Button();
            this.buttonSPlus = new System.Windows.Forms.Button();
            this.buttonS_C = new System.Windows.Forms.Button();
            this.buttonSCE = new System.Windows.Forms.Button();
            this.buttonS7 = new System.Windows.Forms.Button();
            this.buttonS8 = new System.Windows.Forms.Button();
            this.buttonS9 = new System.Windows.Forms.Button();
            this.buttonS4 = new System.Windows.Forms.Button();
            this.buttonS5 = new System.Windows.Forms.Button();
            this.buttonS6 = new System.Windows.Forms.Button();
            this.buttonS1 = new System.Windows.Forms.Button();
            this.buttonS2 = new System.Windows.Forms.Button();
            this.buttonS3 = new System.Windows.Forms.Button();
            this.textBox2Screen = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.textBoxHistory1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPoint);
            this.splitContainer1.Panel1.Controls.Add(this.button0);
            this.splitContainer1.Panel1.Controls.Add(this.button16);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMultiply);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDivide);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMinus);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPlus);
            this.splitContainer1.Panel1.Controls.Add(this.buttonC);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCE);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1Screen);
            this.splitContainer1.Panel1.Click += new System.EventHandler(this.buttonNumber_Click);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.buttonDeleteHistory);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxHistory);
            this.splitContainer1.Panel2.Click += new System.EventHandler(this.buttonSigns_Click);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(501, 406);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.images__1_;
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHistory.Location = new System.Drawing.Point(239, 6);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(35, 39);
            this.buttonHistory.TabIndex = 40;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 39;
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.Location = new System.Drawing.Point(8, 306);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(66, 41);
            this.buttonPoint.TabIndex = 38;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(78, 306);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(66, 41);
            this.button0.TabIndex = 37;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(148, 306);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(66, 41);
            this.button16.TabIndex = 36;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Gray;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.White;
            this.buttonMultiply.Location = new System.Drawing.Point(219, 255);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(48, 45);
            this.buttonMultiply.TabIndex = 35;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonSigns_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Gray;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.ForeColor = System.Drawing.Color.White;
            this.buttonDivide.Location = new System.Drawing.Point(219, 302);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(48, 45);
            this.buttonDivide.TabIndex = 34;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonSigns_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Gray;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.ForeColor = System.Drawing.Color.White;
            this.buttonMinus.Location = new System.Drawing.Point(219, 205);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(48, 45);
            this.buttonMinus.TabIndex = 33;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonSigns_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Gray;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.ForeColor = System.Drawing.Color.White;
            this.buttonPlus.Location = new System.Drawing.Point(219, 153);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(48, 45);
            this.buttonPlus.TabIndex = 32;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonSigns_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Gray;
            this.buttonC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(139, 353);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(128, 47);
            this.buttonC.TabIndex = 31;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.Gray;
            this.buttonCE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.ForeColor = System.Drawing.Color.White;
            this.buttonCE.Location = new System.Drawing.Point(5, 353);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(128, 47);
            this.buttonCE.TabIndex = 30;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(8, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 45);
            this.button9.TabIndex = 29;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(78, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 45);
            this.button8.TabIndex = 28;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(148, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 45);
            this.button7.TabIndex = 27;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(8, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 45);
            this.button6.TabIndex = 26;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(78, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 45);
            this.button5.TabIndex = 25;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(148, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 45);
            this.button4.TabIndex = 24;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(8, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 45);
            this.button3.TabIndex = 23;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(78, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // textBox1Screen
            // 
            this.textBox1Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Screen.ForeColor = System.Drawing.Color.White;
            this.textBox1Screen.Location = new System.Drawing.Point(8, 48);
            this.textBox1Screen.Multiline = true;
            this.textBox1Screen.Name = "textBox1Screen";
            this.textBox1Screen.ReadOnly = true;
            this.textBox1Screen.Size = new System.Drawing.Size(259, 99);
            this.textBox1Screen.TabIndex = 20;
            this.textBox1Screen.Text = "0";
            this.textBox1Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonDeleteHistory
            // 
            this.buttonDeleteHistory.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.pngtree_recycle_bin_icon_for_your_project_png_image_1600015;
            this.buttonDeleteHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteHistory.Location = new System.Drawing.Point(187, 371);
            this.buttonDeleteHistory.Name = "buttonDeleteHistory";
            this.buttonDeleteHistory.Size = new System.Drawing.Size(34, 46);
            this.buttonDeleteHistory.TabIndex = 2;
            this.buttonDeleteHistory.UseVisualStyleBackColor = true;
            this.buttonDeleteHistory.Click += new System.EventHandler(this.buttonDeleteHistory_Click);
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxHistory.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistory.ForeColor = System.Drawing.Color.White;
            this.textBoxHistory.Location = new System.Drawing.Point(0, 0);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.Size = new System.Drawing.Size(220, 372);
            this.textBoxHistory.TabIndex = 1;
            this.textBoxHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scientific";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSHistory);
            this.splitContainer2.Panel1.Controls.Add(this.buttonMS);
            this.splitContainer2.Panel1.Controls.Add(this.buttonM_Minus);
            this.splitContainer2.Panel1.Controls.Add(this.buttonMPlus);
            this.splitContainer2.Panel1.Controls.Add(this.buttonMR);
            this.splitContainer2.Panel1.Controls.Add(this.buttonMC);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSDelete);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSPlusMinus);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSPercent);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSSQRT);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSFormula);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSPoint);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS0);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSEqual);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSMultiply);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSDivide);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSMinus);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSPlus);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS_C);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSCE);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS7);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS8);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS9);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS4);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS5);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS6);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS1);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS2);
            this.splitContainer2.Panel1.Controls.Add(this.buttonS3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2Screen);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer2.Panel2.Controls.Add(this.button11);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxHistory1);
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.Silver;
            this.splitContainer2.Panel2.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            this.splitContainer2.Size = new System.Drawing.Size(501, 451);
            this.splitContainer2.SplitterDistance = 322;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 72;
            // 
            // buttonSHistory
            // 
            this.buttonSHistory.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.images__1_;
            this.buttonSHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSHistory.Location = new System.Drawing.Point(283, 0);
            this.buttonSHistory.Name = "buttonSHistory";
            this.buttonSHistory.Size = new System.Drawing.Size(36, 39);
            this.buttonSHistory.TabIndex = 71;
            this.buttonSHistory.UseVisualStyleBackColor = true;
            // 
            // buttonMS
            // 
            this.buttonMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMS.ForeColor = System.Drawing.Color.White;
            this.buttonMS.Location = new System.Drawing.Point(214, 106);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(47, 49);
            this.buttonMS.TabIndex = 70;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = false;
            this.buttonMS.Click += new System.EventHandler(this.M_Buttons_Click);
            // 
            // buttonM_Minus
            // 
            this.buttonM_Minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonM_Minus.ForeColor = System.Drawing.Color.White;
            this.buttonM_Minus.Location = new System.Drawing.Point(162, 106);
            this.buttonM_Minus.Name = "buttonM_Minus";
            this.buttonM_Minus.Size = new System.Drawing.Size(47, 49);
            this.buttonM_Minus.TabIndex = 69;
            this.buttonM_Minus.Text = "M-";
            this.buttonM_Minus.UseVisualStyleBackColor = false;
            this.buttonM_Minus.Click += new System.EventHandler(this.M_Buttons_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMPlus.ForeColor = System.Drawing.Color.White;
            this.buttonMPlus.Location = new System.Drawing.Point(109, 106);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(47, 49);
            this.buttonMPlus.TabIndex = 68;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = false;
            this.buttonMPlus.Click += new System.EventHandler(this.M_Buttons_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMR.ForeColor = System.Drawing.Color.Silver;
            this.buttonMR.Location = new System.Drawing.Point(56, 106);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(47, 49);
            this.buttonMR.TabIndex = 67;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = false;
            this.buttonMR.Click += new System.EventHandler(this.M_Buttons_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMC.ForeColor = System.Drawing.Color.Silver;
            this.buttonMC.Location = new System.Drawing.Point(3, 106);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(47, 49);
            this.buttonMC.TabIndex = 66;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = false;
            this.buttonMC.Click += new System.EventHandler(this.M_Buttons_Click);
            // 
            // buttonSDelete
            // 
            this.buttonSDelete.BackColor = System.Drawing.Color.Red;
            this.buttonSDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSDelete.ForeColor = System.Drawing.Color.White;
            this.buttonSDelete.Location = new System.Drawing.Point(267, 106);
            this.buttonSDelete.Name = "buttonSDelete";
            this.buttonSDelete.Size = new System.Drawing.Size(49, 49);
            this.buttonSDelete.TabIndex = 65;
            this.buttonSDelete.Text = "DEL";
            this.buttonSDelete.UseVisualStyleBackColor = false;
            this.buttonSDelete.Click += new System.EventHandler(this.buttonS_Delete_Click);
            // 
            // buttonSPlusMinus
            // 
            this.buttonSPlusMinus.BackColor = System.Drawing.Color.Gray;
            this.buttonSPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSPlusMinus.ForeColor = System.Drawing.Color.White;
            this.buttonSPlusMinus.Location = new System.Drawing.Point(268, 315);
            this.buttonSPlusMinus.Name = "buttonSPlusMinus";
            this.buttonSPlusMinus.Size = new System.Drawing.Size(48, 40);
            this.buttonSPlusMinus.TabIndex = 64;
            this.buttonSPlusMinus.Text = "+/_";
            this.buttonSPlusMinus.UseVisualStyleBackColor = false;
            this.buttonSPlusMinus.Click += new System.EventHandler(this.ScientificButtons);
            // 
            // buttonSPercent
            // 
            this.buttonSPercent.BackColor = System.Drawing.Color.Gray;
            this.buttonSPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSPercent.ForeColor = System.Drawing.Color.White;
            this.buttonSPercent.Location = new System.Drawing.Point(268, 264);
            this.buttonSPercent.Name = "buttonSPercent";
            this.buttonSPercent.Size = new System.Drawing.Size(48, 45);
            this.buttonSPercent.TabIndex = 63;
            this.buttonSPercent.Text = "%";
            this.buttonSPercent.UseVisualStyleBackColor = false;
            this.buttonSPercent.Click += new System.EventHandler(this.ButtonS_Percent_Click);
            // 
            // buttonSSQRT
            // 
            this.buttonSSQRT.BackColor = System.Drawing.Color.Gray;
            this.buttonSSQRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSSQRT.ForeColor = System.Drawing.Color.White;
            this.buttonSSQRT.Location = new System.Drawing.Point(268, 213);
            this.buttonSSQRT.Name = "buttonSSQRT";
            this.buttonSSQRT.Size = new System.Drawing.Size(48, 45);
            this.buttonSSQRT.TabIndex = 62;
            this.buttonSSQRT.Text = "sqrt";
            this.buttonSSQRT.UseVisualStyleBackColor = false;
            this.buttonSSQRT.Click += new System.EventHandler(this.ScientificButtons);
            // 
            // buttonSFormula
            // 
            this.buttonSFormula.BackColor = System.Drawing.Color.Gray;
            this.buttonSFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSFormula.ForeColor = System.Drawing.Color.White;
            this.buttonSFormula.Location = new System.Drawing.Point(268, 162);
            this.buttonSFormula.Name = "buttonSFormula";
            this.buttonSFormula.Size = new System.Drawing.Size(48, 44);
            this.buttonSFormula.TabIndex = 61;
            this.buttonSFormula.Text = "1/x";
            this.buttonSFormula.UseVisualStyleBackColor = false;
            this.buttonSFormula.Click += new System.EventHandler(this.ScientificButtons);
            // 
            // buttonSPoint
            // 
            this.buttonSPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSPoint.Location = new System.Drawing.Point(3, 314);
            this.buttonSPoint.Name = "buttonSPoint";
            this.buttonSPoint.Size = new System.Drawing.Size(66, 41);
            this.buttonSPoint.TabIndex = 59;
            this.buttonSPoint.Text = ",";
            this.buttonSPoint.UseVisualStyleBackColor = true;
            this.buttonSPoint.Click += new System.EventHandler(this.ButtonS_Point_Click);
            // 
            // buttonS0
            // 
            this.buttonS0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS0.Location = new System.Drawing.Point(73, 314);
            this.buttonS0.Name = "buttonS0";
            this.buttonS0.Size = new System.Drawing.Size(66, 41);
            this.buttonS0.TabIndex = 58;
            this.buttonS0.Text = "0";
            this.buttonS0.UseVisualStyleBackColor = true;
            this.buttonS0.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonSEqual
            // 
            this.buttonSEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSEqual.Location = new System.Drawing.Point(143, 314);
            this.buttonSEqual.Name = "buttonSEqual";
            this.buttonSEqual.Size = new System.Drawing.Size(66, 41);
            this.buttonSEqual.TabIndex = 57;
            this.buttonSEqual.Text = "=";
            this.buttonSEqual.UseVisualStyleBackColor = false;
            this.buttonSEqual.Click += new System.EventHandler(this.ButtonS_Equal_Click);
            // 
            // buttonSMultiply
            // 
            this.buttonSMultiply.BackColor = System.Drawing.Color.Gray;
            this.buttonSMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSMultiply.ForeColor = System.Drawing.Color.White;
            this.buttonSMultiply.Location = new System.Drawing.Point(214, 263);
            this.buttonSMultiply.Name = "buttonSMultiply";
            this.buttonSMultiply.Size = new System.Drawing.Size(48, 45);
            this.buttonSMultiply.TabIndex = 56;
            this.buttonSMultiply.Text = "*";
            this.buttonSMultiply.UseVisualStyleBackColor = false;
            this.buttonSMultiply.Click += new System.EventHandler(this.ButtonS_Signs_Click);
            // 
            // buttonSDivide
            // 
            this.buttonSDivide.BackColor = System.Drawing.Color.Gray;
            this.buttonSDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSDivide.ForeColor = System.Drawing.Color.White;
            this.buttonSDivide.Location = new System.Drawing.Point(214, 314);
            this.buttonSDivide.Name = "buttonSDivide";
            this.buttonSDivide.Size = new System.Drawing.Size(48, 41);
            this.buttonSDivide.TabIndex = 55;
            this.buttonSDivide.Text = "/";
            this.buttonSDivide.UseVisualStyleBackColor = false;
            this.buttonSDivide.Click += new System.EventHandler(this.ButtonS_Signs_Click);
            // 
            // buttonSMinus
            // 
            this.buttonSMinus.BackColor = System.Drawing.Color.Gray;
            this.buttonSMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSMinus.ForeColor = System.Drawing.Color.White;
            this.buttonSMinus.Location = new System.Drawing.Point(214, 213);
            this.buttonSMinus.Name = "buttonSMinus";
            this.buttonSMinus.Size = new System.Drawing.Size(48, 45);
            this.buttonSMinus.TabIndex = 54;
            this.buttonSMinus.Text = "-";
            this.buttonSMinus.UseVisualStyleBackColor = false;
            this.buttonSMinus.Click += new System.EventHandler(this.ButtonS_Signs_Click);
            // 
            // buttonSPlus
            // 
            this.buttonSPlus.BackColor = System.Drawing.Color.Gray;
            this.buttonSPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSPlus.ForeColor = System.Drawing.Color.White;
            this.buttonSPlus.Location = new System.Drawing.Point(214, 161);
            this.buttonSPlus.Name = "buttonSPlus";
            this.buttonSPlus.Size = new System.Drawing.Size(48, 45);
            this.buttonSPlus.TabIndex = 53;
            this.buttonSPlus.Text = "+";
            this.buttonSPlus.UseVisualStyleBackColor = false;
            this.buttonSPlus.Click += new System.EventHandler(this.ButtonS_Signs_Click);
            // 
            // buttonS_C
            // 
            this.buttonS_C.BackColor = System.Drawing.Color.Gray;
            this.buttonS_C.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS_C.ForeColor = System.Drawing.Color.White;
            this.buttonS_C.Location = new System.Drawing.Point(162, 361);
            this.buttonS_C.Name = "buttonS_C";
            this.buttonS_C.Size = new System.Drawing.Size(155, 47);
            this.buttonS_C.TabIndex = 52;
            this.buttonS_C.Text = "C";
            this.buttonS_C.UseVisualStyleBackColor = false;
            this.buttonS_C.Click += new System.EventHandler(this.ButtonS_C_Click);
            // 
            // buttonSCE
            // 
            this.buttonSCE.BackColor = System.Drawing.Color.Gray;
            this.buttonSCE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSCE.ForeColor = System.Drawing.Color.White;
            this.buttonSCE.Location = new System.Drawing.Point(5, 361);
            this.buttonSCE.Name = "buttonSCE";
            this.buttonSCE.Size = new System.Drawing.Size(151, 47);
            this.buttonSCE.TabIndex = 51;
            this.buttonSCE.Text = "CE";
            this.buttonSCE.UseVisualStyleBackColor = false;
            this.buttonSCE.Click += new System.EventHandler(this.ButtonS_CE_Click);
            // 
            // buttonS7
            // 
            this.buttonS7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS7.Location = new System.Drawing.Point(3, 161);
            this.buttonS7.Name = "buttonS7";
            this.buttonS7.Size = new System.Drawing.Size(63, 45);
            this.buttonS7.TabIndex = 50;
            this.buttonS7.Text = "7";
            this.buttonS7.UseVisualStyleBackColor = false;
            this.buttonS7.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS8
            // 
            this.buttonS8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS8.Location = new System.Drawing.Point(73, 161);
            this.buttonS8.Name = "buttonS8";
            this.buttonS8.Size = new System.Drawing.Size(64, 45);
            this.buttonS8.TabIndex = 49;
            this.buttonS8.Text = "8";
            this.buttonS8.UseVisualStyleBackColor = false;
            this.buttonS8.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS9
            // 
            this.buttonS9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS9.Location = new System.Drawing.Point(143, 161);
            this.buttonS9.Name = "buttonS9";
            this.buttonS9.Size = new System.Drawing.Size(65, 45);
            this.buttonS9.TabIndex = 48;
            this.buttonS9.Text = "9";
            this.buttonS9.UseVisualStyleBackColor = false;
            this.buttonS9.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS4
            // 
            this.buttonS4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS4.Location = new System.Drawing.Point(3, 212);
            this.buttonS4.Name = "buttonS4";
            this.buttonS4.Size = new System.Drawing.Size(63, 45);
            this.buttonS4.TabIndex = 47;
            this.buttonS4.Text = "4";
            this.buttonS4.UseVisualStyleBackColor = false;
            this.buttonS4.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS5
            // 
            this.buttonS5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS5.Location = new System.Drawing.Point(73, 212);
            this.buttonS5.Name = "buttonS5";
            this.buttonS5.Size = new System.Drawing.Size(64, 45);
            this.buttonS5.TabIndex = 46;
            this.buttonS5.Text = "5";
            this.buttonS5.UseVisualStyleBackColor = false;
            this.buttonS5.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS6
            // 
            this.buttonS6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS6.Location = new System.Drawing.Point(143, 212);
            this.buttonS6.Name = "buttonS6";
            this.buttonS6.Size = new System.Drawing.Size(65, 45);
            this.buttonS6.TabIndex = 45;
            this.buttonS6.Text = "6";
            this.buttonS6.UseVisualStyleBackColor = false;
            this.buttonS6.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS1
            // 
            this.buttonS1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS1.Location = new System.Drawing.Point(3, 263);
            this.buttonS1.Name = "buttonS1";
            this.buttonS1.Size = new System.Drawing.Size(64, 45);
            this.buttonS1.TabIndex = 44;
            this.buttonS1.Text = "1";
            this.buttonS1.UseVisualStyleBackColor = false;
            this.buttonS1.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS2
            // 
            this.buttonS2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS2.Location = new System.Drawing.Point(73, 263);
            this.buttonS2.Name = "buttonS2";
            this.buttonS2.Size = new System.Drawing.Size(64, 45);
            this.buttonS2.TabIndex = 43;
            this.buttonS2.Text = "2";
            this.buttonS2.UseVisualStyleBackColor = false;
            this.buttonS2.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // buttonS3
            // 
            this.buttonS3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS3.Location = new System.Drawing.Point(143, 263);
            this.buttonS3.Name = "buttonS3";
            this.buttonS3.Size = new System.Drawing.Size(65, 45);
            this.buttonS3.TabIndex = 42;
            this.buttonS3.Text = "3";
            this.buttonS3.UseVisualStyleBackColor = false;
            this.buttonS3.Click += new System.EventHandler(this.ButtonSNumbers_Click);
            // 
            // textBox2Screen
            // 
            this.textBox2Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Screen.ForeColor = System.Drawing.Color.White;
            this.textBox2Screen.Location = new System.Drawing.Point(5, 42);
            this.textBox2Screen.Multiline = true;
            this.textBox2Screen.Name = "textBox2Screen";
            this.textBox2Screen.ReadOnly = true;
            this.textBox2Screen.Size = new System.Drawing.Size(314, 58);
            this.textBox2Screen.TabIndex = 41;
            this.textBox2Screen.Text = "0";
            this.textBox2Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.pngtree_recycle_bin_icon_for_your_project_png_image_1600015;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button11.Location = new System.Drawing.Point(141, 369);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(34, 46);
            this.button11.TabIndex = 3;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonS_Delete_History);
            // 
            // textBoxHistory1
            // 
            this.textBoxHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxHistory1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistory1.ForeColor = System.Drawing.Color.White;
            this.textBoxHistory1.Location = new System.Drawing.Point(3, 0);
            this.textBoxHistory1.Multiline = true;
            this.textBoxHistory1.Name = "textBoxHistory1";
            this.textBoxHistory1.Size = new System.Drawing.Size(172, 367);
            this.textBoxHistory1.TabIndex = 0;
            this.textBoxHistory1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 45);
            this.panel1.TabIndex = 1;
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(515, 483);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1Screen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Button buttonDeleteHistory;
        private System.Windows.Forms.Button buttonSPoint;
        private System.Windows.Forms.Button buttonS0;
        private System.Windows.Forms.Button buttonSEqual;
        private System.Windows.Forms.Button buttonSMultiply;
        private System.Windows.Forms.Button buttonSDivide;
        private System.Windows.Forms.Button buttonSMinus;
        private System.Windows.Forms.Button buttonSPlus;
        private System.Windows.Forms.Button buttonS_C;
        private System.Windows.Forms.Button buttonSCE;
        private System.Windows.Forms.Button buttonS7;
        private System.Windows.Forms.Button buttonS8;
        private System.Windows.Forms.Button buttonS9;
        private System.Windows.Forms.Button buttonS4;
        private System.Windows.Forms.Button buttonS5;
        private System.Windows.Forms.Button buttonS6;
        private System.Windows.Forms.Button buttonS1;
        private System.Windows.Forms.Button buttonS2;
        private System.Windows.Forms.Button buttonS3;
        private System.Windows.Forms.TextBox textBox2Screen;
        private System.Windows.Forms.Button buttonSPlusMinus;
        private System.Windows.Forms.Button buttonSPercent;
        private System.Windows.Forms.Button buttonSSQRT;
        private System.Windows.Forms.Button buttonSFormula;
        private System.Windows.Forms.Button buttonSDelete;
        private System.Windows.Forms.Button buttonSHistory;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonM_Minus;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHistory1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel1;
    }
}

