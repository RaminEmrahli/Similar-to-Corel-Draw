namespace SDF2
{
    partial class FrmGrups
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
            listBox1 = new ListBox();
            btnAddGroup = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(-1, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(227, 469);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(151, 0);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(75, 23);
            btnAddGroup.TabIndex = 1;
            btnAddGroup.Text = "New Group";
            btnAddGroup.UseVisualStyleBackColor = true;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(241, 29);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(548, 454);
            listBox2.TabIndex = 2;
            // 
            // FrmGrups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 497);
            Controls.Add(listBox2);
            Controls.Add(btnAddGroup);
            Controls.Add(listBox1);
            Name = "FrmGrups";
            Text = "FrmGrups";
            Load += FrmGrups_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnAddGroup;
        private ListBox listBox2;
    }
}