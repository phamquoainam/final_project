namespace IETS
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.category_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category_category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.category_addBtn = new System.Windows.Forms.Button();
            this.category_updateBtn = new System.Windows.Forms.Button();
            this.category_clearBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.category_clearBtn);
            this.panel1.Controls.Add(this.category_updateBtn);
            this.panel1.Controls.Add(this.category_addBtn);
            this.panel1.Controls.Add(this.category_status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.category_type);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.category_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 516);
            this.panel1.TabIndex = 0;
            // 
            // category_status
            // 
            this.category_status.FormattingEnabled = true;
            this.category_status.Items.AddRange(new object[] {
            "Income",
            "Expenses"});
            this.category_status.Location = new System.Drawing.Point(32, 240);
            this.category_status.Name = "category_status";
            this.category_status.Size = new System.Drawing.Size(240, 24);
            this.category_status.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // category_type
            // 
            this.category_type.FormattingEnabled = true;
            this.category_type.Items.AddRange(new object[] {
            "Income",
            "Expenses"});
            this.category_type.Location = new System.Drawing.Point(32, 157);
            this.category_type.Name = "category_type";
            this.category_type.Size = new System.Drawing.Size(240, 24);
            this.category_type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // category_category
            // 
            this.category_category.Location = new System.Drawing.Point(32, 78);
            this.category_category.Name = "category_category";
            this.category_category.Size = new System.Drawing.Size(242, 22);
            this.category_category.TabIndex = 1;
            this.category_category.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(353, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 516);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categores list";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(427, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // category_addBtn
            // 
            this.category_addBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.category_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_addBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.category_addBtn.Location = new System.Drawing.Point(32, 306);
            this.category_addBtn.Name = "category_addBtn";
            this.category_addBtn.Size = new System.Drawing.Size(94, 43);
            this.category_addBtn.TabIndex = 6;
            this.category_addBtn.Text = "Add";
            this.category_addBtn.UseVisualStyleBackColor = false;
            // 
            // category_updateBtn
            // 
            this.category_updateBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.category_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.category_updateBtn.Location = new System.Drawing.Point(178, 306);
            this.category_updateBtn.Name = "category_updateBtn";
            this.category_updateBtn.Size = new System.Drawing.Size(94, 43);
            this.category_updateBtn.TabIndex = 7;
            this.category_updateBtn.Text = "Update";
            this.category_updateBtn.UseVisualStyleBackColor = false;
            // 
            // category_clearBtn
            // 
            this.category_clearBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.category_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.category_clearBtn.Location = new System.Drawing.Point(32, 378);
            this.category_clearBtn.Name = "category_clearBtn";
            this.category_clearBtn.Size = new System.Drawing.Size(94, 43);
            this.category_clearBtn.TabIndex = 8;
            this.category_clearBtn.Text = "Clear";
            this.category_clearBtn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(178, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 43);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.Text = "Category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category_type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button category_addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button category_updateBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button category_clearBtn;
    }
}