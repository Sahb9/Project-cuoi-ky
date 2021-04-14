namespace Final_Project
{
    partial class quanLySach
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BT_Search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Sửa = new System.Windows.Forms.Button();
            this.BT_Xóa = new System.Windows.Forms.Button();
            this.BT_Thêm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 28);
            this.textBox1.TabIndex = 7;
            // 
            // BT_Search
            // 
            this.BT_Search.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BT_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BT_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Search.BorderRadius = 0;
            this.BT_Search.ButtonText = "Search";
            this.BT_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Search.DisabledColor = System.Drawing.Color.Gray;
            this.BT_Search.Iconcolor = System.Drawing.Color.Transparent;
            this.BT_Search.Iconimage = null;
            this.BT_Search.Iconimage_right = null;
            this.BT_Search.Iconimage_right_Selected = null;
            this.BT_Search.Iconimage_Selected = null;
            this.BT_Search.IconMarginLeft = 0;
            this.BT_Search.IconMarginRight = 0;
            this.BT_Search.IconRightVisible = true;
            this.BT_Search.IconRightZoom = 0D;
            this.BT_Search.IconVisible = true;
            this.BT_Search.IconZoom = 90D;
            this.BT_Search.IsTab = false;
            this.BT_Search.Location = new System.Drawing.Point(214, 21);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BT_Search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BT_Search.OnHoverTextColor = System.Drawing.Color.White;
            this.BT_Search.selected = false;
            this.BT_Search.Size = new System.Drawing.Size(89, 28);
            this.BT_Search.TabIndex = 8;
            this.BT_Search.Text = "Search";
            this.BT_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_Search.Textcolor = System.Drawing.Color.White;
            this.BT_Search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.BT_Sửa);
            this.panel1.Controls.Add(this.BT_Xóa);
            this.panel1.Controls.Add(this.BT_Thêm);
            this.panel1.Location = new System.Drawing.Point(44, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 81);
            this.panel1.TabIndex = 12;
            // 
            // BT_Sửa
            // 
            this.BT_Sửa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.BT_Sửa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Sửa.Location = new System.Drawing.Point(20, 12);
            this.BT_Sửa.Name = "BT_Sửa";
            this.BT_Sửa.Size = new System.Drawing.Size(75, 49);
            this.BT_Sửa.TabIndex = 2;
            this.BT_Sửa.TabStop = false;
            this.BT_Sửa.Text = "Sửa";
            this.BT_Sửa.UseVisualStyleBackColor = false;
            // 
            // BT_Xóa
            // 
            this.BT_Xóa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.BT_Xóa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Xóa.Location = new System.Drawing.Point(98, 12);
            this.BT_Xóa.Name = "BT_Xóa";
            this.BT_Xóa.Size = new System.Drawing.Size(75, 49);
            this.BT_Xóa.TabIndex = 1;
            this.BT_Xóa.TabStop = false;
            this.BT_Xóa.Text = "Xóa";
            this.BT_Xóa.UseVisualStyleBackColor = false;
            // 
            // BT_Thêm
            // 
            this.BT_Thêm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.BT_Thêm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Thêm.Location = new System.Drawing.Point(179, 12);
            this.BT_Thêm.Name = "BT_Thêm";
            this.BT_Thêm.Size = new System.Drawing.Size(75, 49);
            this.BT_Thêm.TabIndex = 0;
            this.BT_Thêm.TabStop = false;
            this.BT_Thêm.Text = "Thêm";
            this.BT_Thêm.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(44, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 201);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng sách ";
            this.Column2.Name = "Column2";
            // 
            // quanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.textBox1);
            this.Name = "quanLySach";
            this.Size = new System.Drawing.Size(652, 399);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton BT_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_Sửa;
        private System.Windows.Forms.Button BT_Xóa;
        private System.Windows.Forms.Button BT_Thêm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
