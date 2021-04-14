namespace Final_Project
{
    partial class FormSinhVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinhVien));
            this.panelx = new System.Windows.Forms.Panel();
            this.buttonQuanLySach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Sửa = new System.Windows.Forms.Button();
            this.BT_Xóa = new System.Windows.Forms.Button();
            this.BT_Thêm = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_Search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelx
            // 
            this.panelx.BackColor = System.Drawing.Color.Red;
            this.panelx.Location = new System.Drawing.Point(132, 173);
            this.panelx.Name = "panelx";
            this.panelx.Size = new System.Drawing.Size(10, 48);
            this.panelx.TabIndex = 10;
            // 
            // buttonQuanLySach
            // 
            this.buttonQuanLySach.FlatAppearance.BorderSize = 0;
            this.buttonQuanLySach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLySach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLySach.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonQuanLySach.Location = new System.Drawing.Point(0, 173);
            this.buttonQuanLySach.Name = "buttonQuanLySach";
            this.buttonQuanLySach.Size = new System.Drawing.Size(142, 48);
            this.buttonQuanLySach.TabIndex = 9;
            this.buttonQuanLySach.TabStop = false;
            this.buttonQuanLySach.Text = "Quản lý sách";
            this.buttonQuanLySach.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chức vụ : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Final_Project.Properties.Resources.multiply;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(562, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Exit";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.BT_Sửa);
            this.panel1.Controls.Add(this.BT_Xóa);
            this.panel1.Controls.Add(this.BT_Thêm);
            this.panel1.Location = new System.Drawing.Point(24, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 81);
            this.panel1.TabIndex = 11;
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
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng sách ";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(24, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(276, 201);
            this.dataGridView1.TabIndex = 8;
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
            this.BT_Search.Location = new System.Drawing.Point(208, 37);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BT_Search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BT_Search.OnHoverTextColor = System.Drawing.Color.White;
            this.BT_Search.selected = false;
            this.BT_Search.Size = new System.Drawing.Size(89, 28);
            this.BT_Search.TabIndex = 7;
            this.BT_Search.Text = "Search";
            this.BT_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_Search.Textcolor = System.Drawing.Color.White;
            this.BT_Search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 28);
            this.textBox1.TabIndex = 6;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.button2);
            this.bunifuGradientPanel2.Controls.Add(this.panel1);
            this.bunifuGradientPanel2.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel2.Controls.Add(this.BT_Search);
            this.bunifuGradientPanel2.Controls.Add(this.textBox1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(142, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(658, 440);
            this.bunifuGradientPanel2.TabIndex = 7;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panelx);
            this.bunifuGradientPanel1.Controls.Add(this.buttonQuanLySach);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(142, 440);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelx;
        private System.Windows.Forms.Button buttonQuanLySach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_Sửa;
        private System.Windows.Forms.Button BT_Xóa;
        private System.Windows.Forms.Button BT_Thêm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton BT_Search;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}