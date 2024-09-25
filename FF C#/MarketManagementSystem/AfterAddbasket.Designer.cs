namespace MarketManagementSystem
{
    partial class AfterAddbasket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMinus = new Button();
            btnPlus = new Button();
            btnCount = new Button();
            SuspendLayout();
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(0, 192, 0);
            btnMinus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(2, 18);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(28, 28);
            btnMinus.TabIndex = 0;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(0, 192, 0);
            btnPlus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(95, 18);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(28, 28);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnCount
            // 
            btnCount.Enabled = false;
            btnCount.Location = new Point(34, 18);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(57, 27);
            btnCount.TabIndex = 1;
            btnCount.Text = "1 pcs.";
            btnCount.UseVisualStyleBackColor = true;
            // 
            // AfterAddbasket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPlus);
            Controls.Add(btnCount);
            Controls.Add(btnMinus);
            Name = "AfterAddbasket";
            Size = new Size(126, 50);
            Load += AfterAddbasket_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinus;
        private Button btnPlus;
        private Button btnCount;
    }
}
