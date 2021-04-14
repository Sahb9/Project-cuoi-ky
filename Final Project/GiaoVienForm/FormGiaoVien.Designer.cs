namespace Final_Project
{
    partial class FormGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoVien));
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMuonSach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelx = new System.Windows.Forms.Panel();
            this.buttonChoMuon = new System.Windows.Forms.Button();
            this.buttonTraSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tình trạng";
            this.Column2.Name = "Column2";
            // 
            // buttonMuonSach
            // 
            this.buttonMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.buttonMuonSach.FlatAppearance.BorderSize = 0;
            this.buttonMuonSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(157)))));
            this.buttonMuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMuonSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuonSach.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMuonSach.Location = new System.Drawing.Point(0, 167);
            this.buttonMuonSach.Name = "buttonMuonSach";
            this.buttonMuonSach.Size = new System.Drawing.Size(142, 48);
            this.buttonMuonSach.TabIndex = 9;
            this.buttonMuonSach.TabStop = false;
            this.buttonMuonSach.Text = "Mượn sách";
            this.buttonMuonSach.UseVisualStyleBackColor = false;
            this.buttonMuonSach.Click += new System.EventHandler(this.buttonMuonSach_Click);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Final_Project.Properties.Resources.multiply;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(598, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Exit";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username: ";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.button2);
            this.bunifuGradientPanel2.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(142, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(699, 423);
            this.bunifuGradientPanel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 399);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chức vụ : ";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panelx);
            this.bunifuGradientPanel1.Controls.Add(this.buttonChoMuon);
            this.bunifuGradientPanel1.Controls.Add(this.buttonTraSach);
            this.bunifuGradientPanel1.Controls.Add(this.buttonMuonSach);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(142, 423);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // panelx
            // 
            this.panelx.BackColor = System.Drawing.Color.Red;
            this.panelx.Location = new System.Drawing.Point(3, 167);
            this.panelx.Name = "panelx";
            this.panelx.Size = new System.Drawing.Size(10, 48);
            this.panelx.TabIndex = 12;
            // 
            // buttonChoMuon
            // 
            this.buttonChoMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.buttonChoMuon.FlatAppearance.BorderSize = 0;
            this.buttonChoMuon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(157)))));
            this.buttonChoMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoMuon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoMuon.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonChoMuon.Location = new System.Drawing.Point(0, 267);
            this.buttonChoMuon.Name = "buttonChoMuon";
            this.buttonChoMuon.Size = new System.Drawing.Size(142, 48);
            this.buttonChoMuon.TabIndex = 11;
            this.buttonChoMuon.TabStop = false;
            this.buttonChoMuon.Text = "Cho thư viện mượn";
            this.buttonChoMuon.UseVisualStyleBackColor = false;
            this.buttonChoMuon.Click += new System.EventHandler(this.buttonChoMuon_Click);
            // 
            // buttonTraSach
            // 
            this.buttonTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            this.buttonTraSach.FlatAppearance.BorderSize = 0;
            this.buttonTraSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(157)))));
            this.buttonTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraSach.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTraSach.Location = new System.Drawing.Point(0, 217);
            this.buttonTraSach.Name = "buttonTraSach";
            this.buttonTraSach.Size = new System.Drawing.Size(142, 48);
            this.buttonTraSach.TabIndex = 10;
            this.buttonTraSach.TabStop = false;
            this.buttonTraSach.Text = "Trả sách";
            this.buttonTraSach.UseVisualStyleBackColor = false;
            this.buttonTraSach.Click += new System.EventHandler(this.buttonTraSach_Click);
            // 
            // FormGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 423);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiaoVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button buttonMuonSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button buttonTraSach;
        private System.Windows.Forms.Button buttonChoMuon;
        private System.Windows.Forms.Panel panelx;
    }
}