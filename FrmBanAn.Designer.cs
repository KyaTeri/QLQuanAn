namespace QLQuanAn
{
    partial class FrmBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanAn));
            this.label5 = new System.Windows.Forms.Label();
            this.TenBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.lsvBan = new System.Windows.Forms.ListView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 67);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bàn ăn";
            // 
            // TenBan
            // 
            this.TenBan.Text = "Tên bàn";
            this.TenBan.Width = 136;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 57;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.SeaShell;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(513, 9);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(57, 43);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lsvBan
            // 
            this.lsvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TenBan});
            this.lsvBan.GridLines = true;
            this.lsvBan.HideSelection = false;
            this.lsvBan.Location = new System.Drawing.Point(372, 79);
            this.lsvBan.Name = "lsvBan";
            this.lsvBan.Size = new System.Drawing.Size(198, 316);
            this.lsvBan.TabIndex = 5;
            this.lsvBan.UseCompatibleStateImageBehavior = false;
            this.lsvBan.View = System.Windows.Forms.View.Details;
            this.lsvBan.SelectedIndexChanged += new System.EventHandler(this.lsvBan_SelectedIndexChanged);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.White;
            this.txtTen.Location = new System.Drawing.Point(122, 83);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(139, 26);
            this.txtTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bàn";
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.White;
            this.txtMa.Location = new System.Drawing.Point(122, 39);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(139, 26);
            this.txtMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bàn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(55, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn ăn";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(106, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Wheat;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(195, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 40);
            this.btnSua.TabIndex = 7;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(19, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 419);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lsvBan);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBanAn";
            this.Load += new System.EventHandler(this.FrmBanAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ColumnHeader TenBan;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lsvBan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}