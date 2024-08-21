namespace ProjectSMC
{
    partial class month1_budget
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
            this.label40 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.month1_save = new System.Windows.Forms.Button();
            this.target_january = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label40.ForeColor = System.Drawing.Color.Gold;
            this.label40.Location = new System.Drawing.Point(77, 9);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(299, 38);
            this.label40.TabIndex = 6;
            this.label40.Text = "TARGET OF JANUARY";
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.month1_save);
            this.panel3.Controls.Add(this.label40);
            this.panel3.Controls.Add(this.target_january);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 184);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // month1_save
            // 
            this.month1_save.Location = new System.Drawing.Point(166, 130);
            this.month1_save.Name = "month1_save";
            this.month1_save.Size = new System.Drawing.Size(97, 30);
            this.month1_save.TabIndex = 10;
            this.month1_save.Text = "Save";
            this.month1_save.UseVisualStyleBackColor = true;
            this.month1_save.Click += new System.EventHandler(this.month1_save_Click);
            // 
            // target_january
            // 
            this.target_january.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.target_january.ForeColor = System.Drawing.Color.LimeGreen;
            this.target_january.Location = new System.Drawing.Point(60, 60);
            this.target_january.Name = "target_january";
            this.target_january.Size = new System.Drawing.Size(326, 47);
            this.target_january.TabIndex = 9;
            this.target_january.TextChanged += new System.EventHandler(this.textBox25_TextChanged);
            // 
            // month1_budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 187);
            this.Controls.Add(this.panel3);
            this.Name = "month1_budget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "month1_budget";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button month1_save;
        public System.Windows.Forms.TextBox target_january;
    }
}