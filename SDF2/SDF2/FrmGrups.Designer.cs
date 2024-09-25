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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrups));
            btnAddGroup = new Button();
            listBoxGrups = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            listBox2 = new ListBox();
            txtMessage = new TextBox();
            btnSendMessage = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(157, -1);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(75, 23);
            btnAddGroup.TabIndex = 4;
            btnAddGroup.Text = "New Group";
            btnAddGroup.UseVisualStyleBackColor = true;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // listBoxGrups
            // 
            listBoxGrups.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxGrups.FormattingEnabled = true;
            listBoxGrups.ItemHeight = 30;
            listBoxGrups.Location = new Point(5, 28);
            listBoxGrups.Name = "listBoxGrups";
            listBoxGrups.Size = new Size(227, 454);
            listBoxGrups.TabIndex = 3;
            listBoxGrups.SelectedIndexChanged += listBoxGrups_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(258, 223);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(535, 214);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(258, 457);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(489, 27);
            txtMessage.TabIndex = 6;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackgroundImage = (Image)resources.GetObject("btnSendMessage.BackgroundImage");
            btnSendMessage.BackgroundImageLayout = ImageLayout.Stretch;
            btnSendMessage.Location = new Point(753, 456);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(30, 30);
            btnSendMessage.TabIndex = 7;
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // timer2
            // 
            timer2.Interval = 2000;
            timer2.Tick += timer2_Tick;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(397, 76);
            listView1.Name = "listView1";
            listView1.Size = new Size(253, 97);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmGrups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 497);
            Controls.Add(listView1);
            Controls.Add(btnSendMessage);
            Controls.Add(txtMessage);
            Controls.Add(listBox2);
            Controls.Add(btnAddGroup);
            Controls.Add(listBoxGrups);
            Name = "FrmGrups";
            Text = "FrmGrups";
            Load += FrmGrups_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddGroup;
        private ListBox listBoxGrups;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBox2;
        private TextBox txtMessage;
        private Button btnSendMessage;
        private System.Windows.Forms.Timer timer2;
        private ListView listView1;
    }
}