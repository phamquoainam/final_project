using System.Windows.Forms;

namespace ProjectSMC
{
    partial class MainForm
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
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.greetUser = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trans_text2 = new System.Windows.Forms.Label();
            this.trans_text = new System.Windows.Forms.Label();
            this.trans_pic = new System.Windows.Forms.PictureBox();
            this.trans_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.budget_text2 = new System.Windows.Forms.Label();
            this.budget_text1 = new System.Windows.Forms.Label();
            this.budget_pic = new System.Windows.Forms.PictureBox();
            this.budget_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.savem_text = new System.Windows.Forms.Label();
            this.savem_pic = new System.Windows.Forms.PictureBox();
            this.savem_button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.expense_text = new System.Windows.Forms.Label();
            this.expense_pic = new System.Windows.Forms.PictureBox();
            this.expense_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trans_pic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budget_pic)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savem_pic)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(1249, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 25);
            this.close.TabIndex = 4;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.greetUser);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 119);
            this.panel1.TabIndex = 0;
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.greetUser.ForeColor = System.Drawing.Color.Gold;
            this.greetUser.Location = new System.Drawing.Point(191, 47);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(128, 29);
            this.greetUser.TabIndex = 11;
            this.greetUser.Text = "username";
            this.greetUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ProjectSMC.Properties.Resources.fire;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(881, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 50);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProjectSMC.Properties.Resources.settings;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1039, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 48);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProjectSMC.Properties.Resources.notification;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(961, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 49);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjectSMC.Properties.Resources.man;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(37, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Gold;
            this.logout_button.Location = new System.Drawing.Point(1117, 41);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(118, 49);
            this.logout_button.TabIndex = 6;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.trans_text2);
            this.panel2.Controls.Add(this.trans_text);
            this.panel2.Controls.Add(this.trans_pic);
            this.panel2.Controls.Add(this.trans_button);
            this.panel2.Location = new System.Drawing.Point(21, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 189);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // trans_text2
            // 
            this.trans_text2.AutoSize = true;
            this.trans_text2.BackColor = System.Drawing.Color.Transparent;
            this.trans_text2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans_text2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trans_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.trans_text2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trans_text2.Location = new System.Drawing.Point(219, 44);
            this.trans_text2.Name = "trans_text2";
            this.trans_text2.Size = new System.Drawing.Size(163, 29);
            this.trans_text2.TabIndex = 3;
            this.trans_text2.Text = "management";
            this.trans_text2.Click += new System.EventHandler(this.label5_Click);
            this.trans_text2.Parent = this.trans_button;
            // 
            // trans_text
            // 
            this.trans_text.AutoSize = true;
            this.trans_text.BackColor = System.Drawing.Color.Transparent;
            this.trans_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trans_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.trans_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trans_text.Location = new System.Drawing.Point(219, 15);
            this.trans_text.Name = "trans_text";
            this.trans_text.Size = new System.Drawing.Size(163, 29);
            this.trans_text.TabIndex = 1;
            this.trans_text.Text = "Transactions";
            this.trans_text.Click += new System.EventHandler(this.label1_Click_1);
            this.trans_text.Parent = this.trans_button;
            // 
            // trans_pic
            // 
            this.trans_pic.BackColor = System.Drawing.Color.Transparent;
            this.trans_pic.BackgroundImage = global::ProjectSMC.Properties.Resources.paying;
            this.trans_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trans_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans_pic.Location = new System.Drawing.Point(-2, -1);
            this.trans_pic.Name = "trans_pic";
            this.trans_pic.Size = new System.Drawing.Size(204, 189);
            this.trans_pic.TabIndex = 0;
            this.trans_pic.TabStop = false;
            this.trans_pic.Click += new System.EventHandler(this.pictureBox5_Click);
            this.trans_pic.Parent = this.trans_button;
            // 
            // trans_button
            // 
            this.trans_button.BackColor = System.Drawing.Color.LightGray;
            this.trans_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.trans_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trans_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trans_button.Location = new System.Drawing.Point(-2, -1);
            this.trans_button.Name = "trans_button";
            this.trans_button.Size = new System.Drawing.Size(395, 189);
            this.trans_button.TabIndex = 9;
            this.trans_button.UseVisualStyleBackColor = false;
            this.trans_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.budget_text2);
            this.panel3.Controls.Add(this.budget_text1);
            this.panel3.Controls.Add(this.budget_pic);
            this.panel3.Controls.Add(this.budget_button);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(446, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 189);
            this.panel3.TabIndex = 6;
            // 
            // budget_text2
            // 
            this.budget_text2.AutoSize = true;
            this.budget_text2.BackColor = System.Drawing.Color.Transparent;
            this.budget_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.budget_text2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.budget_text2.Location = new System.Drawing.Point(250, 43);
            this.budget_text2.Name = "budget_text2";
            this.budget_text2.Size = new System.Drawing.Size(94, 29);
            this.budget_text2.TabIndex = 2;
            this.budget_text2.Text = "budget";
            this.budget_text2.Click += new System.EventHandler(this.label3_Click);
            this.budget_text2.Parent = this.budget_button;
            // 
            // budget_text1
            // 
            this.budget_text1.AutoSize = true;
            this.budget_text1.BackColor = System.Drawing.Color.Transparent;
            this.budget_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.budget_text1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.budget_text1.Location = new System.Drawing.Point(214, 14);
            this.budget_text1.Name = "budget_text1";
            this.budget_text1.Size = new System.Drawing.Size(153, 29);
            this.budget_text1.TabIndex = 1;
            this.budget_text1.Text = "Expenditure";
            this.budget_text1.Click += new System.EventHandler(this.budget_text1_Click);
            this.budget_text1.Parent = this.budget_button;
            // 
            // budget_pic
            // 
            this.budget_pic.BackColor = System.Drawing.Color.Transparent;
            this.budget_pic.BackgroundImage = global::ProjectSMC.Properties.Resources.money_bag;
            this.budget_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.budget_pic.Location = new System.Drawing.Point(0, 0);
            this.budget_pic.Name = "budget_pic";
            this.budget_pic.Size = new System.Drawing.Size(192, 187);
            this.budget_pic.TabIndex = 0;
            this.budget_pic.TabStop = false;
            this.budget_pic.Click += new System.EventHandler(this.budget_pic_Click);
            this.budget_pic.Parent = this.budget_button;
            // 
            // budget_button
            // 
            this.budget_button.BackColor = System.Drawing.Color.LightGray;
            this.budget_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.budget_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.budget_button.Location = new System.Drawing.Point(-2, -2);
            this.budget_button.Name = "budget_button";
            this.budget_button.Size = new System.Drawing.Size(395, 189);
            this.budget_button.TabIndex = 3;
            this.budget_button.UseVisualStyleBackColor = false;
            this.budget_button.Click += new System.EventHandler(this.budget_button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.savem_text);
            this.panel4.Controls.Add(this.savem_pic);
            this.panel4.Controls.Add(this.savem_button);
            this.panel4.Location = new System.Drawing.Point(19, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 189);
            this.panel4.TabIndex = 7;
            // 
            // savem_text
            // 
            this.savem_text.AutoSize = true;
            this.savem_text.BackColor = System.Drawing.Color.Transparent;
            this.savem_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.savem_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savem_text.Location = new System.Drawing.Point(221, 10);
            this.savem_text.Name = "savem_text";
            this.savem_text.Size = new System.Drawing.Size(141, 29);
            this.savem_text.TabIndex = 2;
            this.savem_text.Text = "Categories";
            this.savem_text.Parent = this.savem_button;
            // 
            // savem_pic
            // 
            this.savem_pic.BackColor = System.Drawing.Color.Transparent;
            this.savem_pic.BackgroundImage = global::ProjectSMC.Properties.Resources.piggy_bank;
            this.savem_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.savem_pic.Location = new System.Drawing.Point(0, 0);
            this.savem_pic.Name = "savem_pic";
            this.savem_pic.Size = new System.Drawing.Size(202, 185);
            this.savem_pic.TabIndex = 0;
            this.savem_pic.TabStop = false;
            this.savem_pic.Parent = this.savem_button;
            // 
            // savem_button
            // 
            this.savem_button.BackColor = System.Drawing.Color.LightGray;
            this.savem_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.savem_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savem_button.Location = new System.Drawing.Point(-2, -1);
            this.savem_button.Name = "savem_button";
            this.savem_button.Size = new System.Drawing.Size(395, 189);
            this.savem_button.TabIndex = 5;
            this.savem_button.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 649);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1284, 66);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.expense_text);
            this.panel6.Controls.Add(this.expense_pic);
            this.panel6.Controls.Add(this.expense_button);
            this.panel6.Location = new System.Drawing.Point(871, 143);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 189);
            this.panel6.TabIndex = 7;
            // 
            // expense_text
            // 
            this.expense_text.AutoSize = true;
            this.expense_text.BackColor = System.Drawing.Color.Transparent;
            this.expense_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.expense_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expense_text.Location = new System.Drawing.Point(241, 14);
            this.expense_text.Name = "expense_text";
            this.expense_text.Size = new System.Drawing.Size(114, 29);
            this.expense_text.TabIndex = 1;
            this.expense_text.Text = "Expense";
            this.expense_text.Parent = this.expense_button;
            // 
            // expense_pic
            // 
            this.expense_pic.BackColor = System.Drawing.Color.Transparent;
            this.expense_pic.BackgroundImage = global::ProjectSMC.Properties.Resources.spending;
            this.expense_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expense_pic.Location = new System.Drawing.Point(0, 0);
            this.expense_pic.Name = "expense_pic";
            this.expense_pic.Size = new System.Drawing.Size(192, 186);
            this.expense_pic.TabIndex = 0;
            this.expense_pic.TabStop = false;
            this.expense_pic.Parent = this.expense_button;
            // 
            // expense_button
            // 
            this.expense_button.BackColor = System.Drawing.Color.LightGray;
            this.expense_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.expense_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_button.Location = new System.Drawing.Point(0, 0);
            this.expense_button.Name = "expense_button";
            this.expense_button.Size = new System.Drawing.Size(395, 189);
            this.expense_button.TabIndex = 4;
            this.expense_button.UseVisualStyleBackColor = false;
            this.expense_button.Click += new System.EventHandler(this.expense_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1284, 715);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trans_pic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budget_pic)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savem_pic)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox trans_pic;
        private System.Windows.Forms.Label trans_text;
        private System.Windows.Forms.PictureBox budget_pic;
        private System.Windows.Forms.PictureBox savem_pic;
        private System.Windows.Forms.Label budget_text2;
        private System.Windows.Forms.Label budget_text1;
        private System.Windows.Forms.Label savem_text;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label expense_text;
        private System.Windows.Forms.PictureBox expense_pic;
        private System.Windows.Forms.Label trans_text2;
        private System.Windows.Forms.Button trans_button;
        private System.Windows.Forms.Button budget_button;
        private System.Windows.Forms.Button savem_button;
        private System.Windows.Forms.Button expense_button;
    }
}