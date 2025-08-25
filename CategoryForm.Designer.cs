namespace RestaurantManagementSystem
{
    partial class CategoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.category_category = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category_status = new System.Windows.Forms.ComboBox();
            this.category_addBtn = new System.Windows.Forms.Button();
            this.category_updateBtn = new System.Windows.Forms.Button();
            this.category_deleteBtn = new System.Windows.Forms.Button();
            this.category_clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.category_deleteBtn);
            this.panel1.Controls.Add(this.category_clearBtn);
            this.panel1.Controls.Add(this.category_updateBtn);
            this.panel1.Controls.Add(this.category_addBtn);
            this.panel1.Controls.Add(this.category_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.category_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 689);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(287, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 689);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "All Categories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 626);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category:";
            // 
            // category_category
            // 
            this.category_category.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_category.Location = new System.Drawing.Point(24, 70);
            this.category_category.Name = "category_category";
            this.category_category.Size = new System.Drawing.Size(228, 24);
            this.category_category.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            // 
            // category_status
            // 
            this.category_status.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status.FormattingEnabled = true;
            this.category_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.category_status.Location = new System.Drawing.Point(24, 134);
            this.category_status.Name = "category_status";
            this.category_status.Size = new System.Drawing.Size(228, 24);
            this.category_status.TabIndex = 8;
            // 
            // category_addBtn
            // 
            this.category_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.category_addBtn.FlatAppearance.BorderSize = 0;
            this.category_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_addBtn.ForeColor = System.Drawing.Color.White;
            this.category_addBtn.Location = new System.Drawing.Point(24, 217);
            this.category_addBtn.Name = "category_addBtn";
            this.category_addBtn.Size = new System.Drawing.Size(92, 47);
            this.category_addBtn.TabIndex = 9;
            this.category_addBtn.Text = "ADD";
            this.category_addBtn.UseVisualStyleBackColor = false;
            this.category_addBtn.Click += new System.EventHandler(this.category_addBtn_Click);
            // 
            // category_updateBtn
            // 
            this.category_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.category_updateBtn.FlatAppearance.BorderSize = 0;
            this.category_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_updateBtn.ForeColor = System.Drawing.Color.White;
            this.category_updateBtn.Location = new System.Drawing.Point(160, 217);
            this.category_updateBtn.Name = "category_updateBtn";
            this.category_updateBtn.Size = new System.Drawing.Size(92, 47);
            this.category_updateBtn.TabIndex = 10;
            this.category_updateBtn.Text = "UPDATE";
            this.category_updateBtn.UseVisualStyleBackColor = false;
            // 
            // category_deleteBtn
            // 
            this.category_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.category_deleteBtn.FlatAppearance.BorderSize = 0;
            this.category_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.category_deleteBtn.Location = new System.Drawing.Point(160, 291);
            this.category_deleteBtn.Name = "category_deleteBtn";
            this.category_deleteBtn.Size = new System.Drawing.Size(92, 47);
            this.category_deleteBtn.TabIndex = 12;
            this.category_deleteBtn.Text = "DELETE";
            this.category_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // category_clearBtn
            // 
            this.category_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.category_clearBtn.FlatAppearance.BorderSize = 0;
            this.category_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.category_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_clearBtn.ForeColor = System.Drawing.Color.White;
            this.category_clearBtn.Location = new System.Drawing.Point(24, 291);
            this.category_clearBtn.Name = "category_clearBtn";
            this.category_clearBtn.Size = new System.Drawing.Size(92, 47);
            this.category_clearBtn.TabIndex = 11;
            this.category_clearBtn.Text = "CLEAR";
            this.category_clearBtn.UseVisualStyleBackColor = false;
            this.category_clearBtn.Click += new System.EventHandler(this.category_clearBtn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
            this.Size = new System.Drawing.Size(1082, 719);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category_category;
        private System.Windows.Forms.ComboBox category_status;
        private System.Windows.Forms.Button category_deleteBtn;
        private System.Windows.Forms.Button category_clearBtn;
        private System.Windows.Forms.Button category_updateBtn;
        private System.Windows.Forms.Button category_addBtn;
    }
}
