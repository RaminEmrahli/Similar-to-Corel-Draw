namespace sdf2hazirliq
{
    partial class Telebeformu
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            Id = new ColumnHeader();
            Name = new ColumnHeader();
            SinifName = new ColumnHeader();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 55);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(130, 151);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "\u007fsave";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, Name, SinifName });
            listView1.GridLines = true;
            listView1.Location = new Point(440, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(205, 183);
            listView1.TabIndex = 6;
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
            // Telebeformu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
           // Name = "Telebeformu";
            Text = "Telebeformu";
            Load += Telebeformu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader Name;
        private ColumnHeader SinifName;
    }
}