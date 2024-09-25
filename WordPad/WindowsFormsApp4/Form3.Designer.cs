namespace WindowsFormsApp4
{
    partial class Form3
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
            this.btnFinderBul = new System.Windows.Forms.Button();
            this.btnFinderIptal = new System.Windows.Forms.Button();
            this.tbFinder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbox1Finder = new System.Windows.Forms.CheckBox();
            this.chbox2Finder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnFinderBul
            // 
            this.btnFinderBul.Location = new System.Drawing.Point(347, 21);
            this.btnFinderBul.Name = "btnFinderBul";
            this.btnFinderBul.Size = new System.Drawing.Size(84, 23);
            this.btnFinderBul.TabIndex = 0;
            this.btnFinderBul.Text = "Sonrakini Bul";
            this.btnFinderBul.UseVisualStyleBackColor = true;
            // 
            // btnFinderIptal
            // 
            this.btnFinderIptal.Location = new System.Drawing.Point(347, 50);
            this.btnFinderIptal.Name = "btnFinderIptal";
            this.btnFinderIptal.Size = new System.Drawing.Size(84, 23);
            this.btnFinderIptal.TabIndex = 1;
            this.btnFinderIptal.Text = "Iptal";
            this.btnFinderIptal.UseVisualStyleBackColor = true;
            this.btnFinderIptal.Click += new System.EventHandler(this.btnFinderIptal_Click);
            // 
            // tbFinder
            // 
            this.tbFinder.Location = new System.Drawing.Point(86, 23);
            this.tbFinder.Name = "tbFinder";
            this.tbFinder.Size = new System.Drawing.Size(255, 20);
            this.tbFinder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranan:";
            // 
            // chbox1Finder
            // 
            this.chbox1Finder.AutoSize = true;
            this.chbox1Finder.Location = new System.Drawing.Point(12, 56);
            this.chbox1Finder.Name = "chbox1Finder";
            this.chbox1Finder.Size = new System.Drawing.Size(168, 17);
            this.chbox1Finder.TabIndex = 4;
            this.chbox1Finder.Text = "Sadece tam sözcükleri eşleştir";
            this.chbox1Finder.UseVisualStyleBackColor = true;
            // 
            // chbox2Finder
            // 
            this.chbox2Finder.AutoSize = true;
            this.chbox2Finder.Location = new System.Drawing.Point(12, 79);
            this.chbox2Finder.Name = "chbox2Finder";
            this.chbox2Finder.Size = new System.Drawing.Size(145, 17);
            this.chbox2Finder.TabIndex = 5;
            this.chbox2Finder.Text = "Büyük küçük harf eşleştir";
            this.chbox2Finder.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 144);
            this.Controls.Add(this.chbox2Finder);
            this.Controls.Add(this.chbox1Finder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFinder);
            this.Controls.Add(this.btnFinderIptal);
            this.Controls.Add(this.btnFinderBul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Bul";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinderBul;
        private System.Windows.Forms.Button btnFinderIptal;
        private System.Windows.Forms.TextBox tbFinder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbox1Finder;
        private System.Windows.Forms.CheckBox chbox2Finder;
    }
}