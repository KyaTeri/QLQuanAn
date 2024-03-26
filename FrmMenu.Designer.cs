namespace QLQuanAn
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvMenu = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DanhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbDanhMuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(21, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(122, 134);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(139, 26);
            this.cbDanhMuc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh mục";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(26, 240);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Wheat;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(109, 240);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(195, 240);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGia.Location = new System.Drawing.Point(122, 183);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(139, 26);
            this.txtGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(16, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá tiền";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTen.Location = new System.Drawing.Point(122, 86);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(139, 26);
            this.txtTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món ăn";
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMa.Location = new System.Drawing.Point(122, 42);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(139, 26);
            this.txtMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã món ăn";
            // 
            // lsvMenu
            // 
            this.lsvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TenMon,
            this.DanhMuc,
            this.GiaTien});
            this.lsvMenu.GridLines = true;
            this.lsvMenu.HideSelection = false;
            this.lsvMenu.Location = new System.Drawing.Point(341, 74);
            this.lsvMenu.Name = "lsvMenu";
            this.lsvMenu.Size = new System.Drawing.Size(421, 336);
            this.lsvMenu.TabIndex = 1;
            this.lsvMenu.UseCompatibleStateImageBehavior = false;
            this.lsvMenu.View = System.Windows.Forms.View.Details;
            this.lsvMenu.SelectedIndexChanged += new System.EventHandler(this.lsvMenu_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 57;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 136;
            // 
            // DanhMuc
            // 
            this.DanhMuc.Text = "Danh mục";
            this.DanhMuc.Width = 110;
            // 
            // GiaTien
            // 
            this.GiaTien.Text = "Giá Tiền";
            this.GiaTien.Width = 113;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.SeaShell;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(705, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(57, 43);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 67);
            this.label5.TabIndex = 3;
            this.label5.Text = "Menu";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 432);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lsvMenu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvMenu;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader DanhMuc;
        private System.Windows.Forms.ColumnHeader GiaTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
    }
}