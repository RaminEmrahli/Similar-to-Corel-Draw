namespace sdf2hazirliq
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
            label1 = new Label();
            txtSinifName = new TextBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            telebeToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            Id = new ColumnHeader();
            Name = new ColumnHeader();
            SinifName = new ColumnHeader();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtSinifName
            // 
            txtSinifName.Location = new Point(104, 31);
            txtSinifName.Name = "txtSinifName";
            txtSinifName.Size = new Size(100, 23);
            txtSinifName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(115, 69);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { telebeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(525, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // telebeToolStripMenuItem
            // 
            telebeToolStripMenuItem.Name = "telebeToolStripMenuItem";
            telebeToolStripMenuItem.Size = new Size(51, 20);
            telebeToolStripMenuItem.Text = "telebe";
            telebeToolStripMenuItem.Click += telebeToolStripMenuItem_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, Name, SinifName });
            listView1.GridLines = true;
            listView1.Location = new Point(245, 69);
            listView1.Name = "listView1";
            listView1.Size = new Size(205, 183);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Id
            // 
            Id.DisplayIndex = 1;
            Id.Text = "Id";
            // 
            // Name
            // 
            Name.DisplayIndex = 0;
            Name.Text = "Name";
            // 
            // SinifName
            // 
            SinifName.Text = "SinifAdi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 302);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(txtSinifName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            //Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSinifName;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem telebeToolStripMenuItem;
        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader Name;
        private ColumnHeader SinifName;
    }
}