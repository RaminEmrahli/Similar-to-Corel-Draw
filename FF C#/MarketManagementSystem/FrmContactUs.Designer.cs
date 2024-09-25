namespace MarketManagementSystem
{
    partial class FrmContactUs
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            richTxtMessage = new RichTextBox();
            btnContactUs = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(26, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(346, 27);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(26, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(202, 77);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(170, 27);
            txtPhone.TabIndex = 2;
            // 
            // richTxtMessage
            // 
            richTxtMessage.Location = new Point(26, 149);
            richTxtMessage.Name = "richTxtMessage";
            richTxtMessage.Size = new Size(346, 140);
            richTxtMessage.TabIndex = 3;
            richTxtMessage.Text = "";
            // 
            // btnContactUs
            // 
            btnContactUs.BackColor = Color.LawnGreen;
            btnContactUs.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactUs.ForeColor = Color.White;
            btnContactUs.Location = new Point(129, 295);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(136, 48);
            btnContactUs.TabIndex = 35;
            btnContactUs.Text = "Mesaj göndər";
            btnContactUs.UseVisualStyleBackColor = false;
            btnContactUs.Click += btnContactUs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 131);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 36;
            label1.Text = "*Mesajınız";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 37;
            label2.Text = "*Adınız";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 59);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 38;
            label3.Text = "*Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 58);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 39;
            label4.Text = "*E-poçt";
            // 
            // FrmContactUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 355);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnContactUs);
            Controls.Add(richTxtMessage);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "FrmContactUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContactUs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private RichTextBox richTxtMessage;
        private Button btnContactUs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}