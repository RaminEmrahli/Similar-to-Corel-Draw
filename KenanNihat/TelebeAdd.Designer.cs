namespace KenanNihat
{
    partial class TelebeAdd
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
            txttelebename = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnTelebeAdd = new Button();
            listViewTelebeler = new ListView();
            columnId = new ColumnHeader();
            columnName = new ColumnHeader();
            columnGroupName = new ColumnHeader();
            SuspendLayout();
            // 
            // txttelebename
            // 
            txttelebename.Location = new Point(83, 21);
            txttelebename.Name = "txttelebename";
            txttelebename.Size = new Size(121, 23);
            txttelebename.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "grupu Secin";
            // 
            // btnTelebeAdd
            // 
            btnTelebeAdd.Location = new Point(83, 107);
            btnTelebeAdd.Name = "btnTelebeAdd";
            btnTelebeAdd.Size = new Size(75, 23);
            btnTelebeAdd.TabIndex = 5;
            btnTelebeAdd.Text = "Save";
            btnTelebeAdd.UseVisualStyleBackColor = true;
            btnTelebeAdd.Click += btnTelebeAdd_Click;
            // 
            // listViewTelebeler
            // 
            listViewTelebeler.Columns.AddRange(new ColumnHeader[] { columnId, columnName, columnGroupName });
            listViewTelebeler.GridLines = true;
            listViewTelebeler.Location = new Point(277, 12);
            listViewTelebeler.Name = "listViewTelebeler";
            listViewTelebeler.Size = new Size(397, 303);
            listViewTelebeler.TabIndex = 6;
            listViewTelebeler.UseCompatibleStateImageBehavior = false;
            listViewTelebeler.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "Id";
            columnId.Width = 50;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 150;
            // 
            // columnGroupName
            // 
            columnGroupName.Text = "GroupName";
            columnGroupName.Width = 150;
            // 
            // TelebeAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 327);
            Controls.Add(listViewTelebeler);
            Controls.Add(btnTelebeAdd);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(txttelebename);
            Name = "TelebeAdd";
            Text = "TelebeAdd";
            Load += TelebeAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txttelebename;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnTelebeAdd;
        private ListView listViewTelebeler;
        private ColumnHeader columnId;
        private ColumnHeader columnName;
        private ColumnHeader columnGroupName;
    }
}