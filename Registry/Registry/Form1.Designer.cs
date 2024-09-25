namespace Registry
{
    partial class Form1
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
            this.buttonLicense = new System.Windows.Forms.Button();
            this.buttonTrial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonLicense
            // 
            this.buttonLicense.BackColor = System.Drawing.Color.Red;
            this.buttonLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLicense.ForeColor = System.Drawing.Color.White;
            this.buttonLicense.Location = new System.Drawing.Point(0, 74);
            this.buttonLicense.Name = "buttonLicense";
            this.buttonLicense.Size = new System.Drawing.Size(136, 62);
            this.buttonLicense.TabIndex = 0;
            this.buttonLicense.Text = "Licensed";
            this.buttonLicense.UseVisualStyleBackColor = false;
            this.buttonLicense.Click += new System.EventHandler(this.buttonLicense_Click);
            // 
            // buttonTrial
            // 
            this.buttonTrial.BackColor = System.Drawing.Color.Lime;
            this.buttonTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrial.ForeColor = System.Drawing.Color.White;
            this.buttonTrial.Location = new System.Drawing.Point(155, 74);
            this.buttonTrial.Name = "buttonTrial";
            this.buttonTrial.Size = new System.Drawing.Size(139, 62);
            this.buttonTrial.TabIndex = 1;
            this.buttonTrial.Text = "Free Trial";
            this.buttonTrial.UseVisualStyleBackColor = false;
            this.buttonTrial.Click += new System.EventHandler(this.buttonTrial_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 68);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 141);
            this.Controls.Add(this.buttonLicense);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTrial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLicense;
        private System.Windows.Forms.Button buttonTrial;
        private System.Windows.Forms.Panel panel1;
    }
}

