namespace SDF2
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
            txtUserName = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(120, 68);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 33);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(120, 107);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 46);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LogIn";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(361, 212);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Button btnLogin;
        private Label label1;
    }
}