namespace MarketManagementSystem
{
    partial class FrmLogIn
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
            linkLabelHome = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            labelValidationUser = new Label();
            labelValidationPassword = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // linkLabelHome
            // 
            linkLabelHome.AutoSize = true;
            linkLabelHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelHome.Location = new Point(12, 9);
            linkLabelHome.Name = "linkLabelHome";
            linkLabelHome.Size = new Size(52, 20);
            linkLabelHome.TabIndex = 0;
            linkLabelHome.TabStop = true;
            linkLabelHome.Text = "Home";
            linkLabelHome.LinkClicked += linkLabelHome_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "/Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 101);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 2;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 141);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(134, 94);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(139, 26);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(134, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(139, 26);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // labelValidationUser
            // 
            labelValidationUser.AutoSize = true;
            labelValidationUser.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidationUser.ForeColor = Color.Red;
            labelValidationUser.Location = new Point(280, 105);
            labelValidationUser.Name = "labelValidationUser";
            labelValidationUser.Size = new Size(0, 15);
            labelValidationUser.TabIndex = 6;
            // 
            // labelValidationPassword
            // 
            labelValidationPassword.AutoSize = true;
            labelValidationPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidationPassword.ForeColor = Color.Red;
            labelValidationPassword.Location = new Point(280, 145);
            labelValidationPassword.Name = "labelValidationPassword";
            labelValidationPassword.Size = new Size(0, 15);
            labelValidationPassword.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(188, 173);
            button1.Name = "button1";
            button1.Size = new Size(85, 44);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSubmit_Click;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 234);
            Controls.Add(button1);
            Controls.Add(labelValidationPassword);
            Controls.Add(labelValidationUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabelHome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelHome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label labelValidationUser;
        private Label labelValidationPassword;
        private Button button1;
    }
}