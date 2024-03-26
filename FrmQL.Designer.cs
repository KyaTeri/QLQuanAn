namespace QLQuanAn
{
    partial class FrmQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQL));
            this.CbDanhMuc = new System.Windows.Forms.ComboBox();
            this.CbMonAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LsvTT = new System.Windows.Forms.ListView();
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.numGiam = new System.Windows.Forms.NumericUpDown();
            this.CbBanAn = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbDanhMuc
            // 
            this.CbDanhMuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbDanhMuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDanhMuc.FormattingEnabled = true;
            this.CbDanhMuc.Location = new System.Drawing.Point(829, 92);
            this.CbDanhMuc.Name = "CbDanhMuc";
            this.CbDanhMuc.Size = new System.Drawing.Size(182, 26);
            this.CbDanhMuc.TabIndex = 0;
            this.CbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.CbDanhMuc_SelectedIndexChanged);
            // 
            // CbMonAn
            // 
            this.CbMonAn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbMonAn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbMonAn.FormattingEnabled = true;
            this.CbMonAn.Location = new System.Drawing.Point(829, 124);
            this.CbMonAn.Name = "CbMonAn";
            this.CbMonAn.Size = new System.Drawing.Size(182, 26);
            this.CbMonAn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(718, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(737, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Món ăn:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numSoLuong.Location = new System.Drawing.Point(1106, 95);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(44, 22);
            this.numSoLuong.TabIndex = 7;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1020, 159);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 29);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSize = true;
            this.btnHuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1106, 159);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 29);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenBan.AutoSize = true;
            this.btnChuyenBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChuyenBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Location = new System.Drawing.Point(931, 159);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(80, 29);
            this.btnChuyenBan.TabIndex = 8;
            this.btnChuyenBan.Text = "Chuyển";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(955, 606);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(159, 63);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(772, 606);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(142, 27);
            this.txtTongTien.TabIndex = 10;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giảm giá(%):";
            // 
            // txtRong
            // 
            this.txtRong.BackColor = System.Drawing.Color.White;
            this.txtRong.Enabled = false;
            this.txtRong.Location = new System.Drawing.Point(627, 552);
            this.txtRong.Name = "txtRong";
            this.txtRong.ReadOnly = true;
            this.txtRong.Size = new System.Drawing.Size(100, 22);
            this.txtRong.TabIndex = 14;
            this.txtRong.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 71);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dim Sum Street";
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.flPanel.Location = new System.Drawing.Point(12, 194);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(597, 489);
            this.flPanel.TabIndex = 16;
            // 
            // LsvTT
            // 
            this.LsvTT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenMon,
            this.SL,
            this.DonGia,
            this.ThanhTien,
            this.ID});
            this.LsvTT.GridLines = true;
            this.LsvTT.HideSelection = false;
            this.LsvTT.Location = new System.Drawing.Point(615, 194);
            this.LsvTT.Name = "LsvTT";
            this.LsvTT.Size = new System.Drawing.Size(591, 397);
            this.LsvTT.TabIndex = 17;
            this.LsvTT.UseCompatibleStateImageBehavior = false;
            this.LsvTT.View = System.Windows.Forms.View.Details;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên Món";
            this.TenMon.Width = 140;
            // 
            // SL
            // 
            this.SL.Text = "SL";
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn Giá";
            this.DonGia.Width = 90;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành Tiền";
            this.ThanhTien.Width = 90;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 46);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bàn ";
            // 
            // numGiam
            // 
            this.numGiam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGiam.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGiam.Location = new System.Drawing.Point(772, 645);
            this.numGiam.Name = "numGiam";
            this.numGiam.Size = new System.Drawing.Size(142, 24);
            this.numGiam.TabIndex = 21;
            this.numGiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbBanAn
            // 
            this.CbBanAn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbBanAn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBanAn.FormattingEnabled = true;
            this.CbBanAn.Location = new System.Drawing.Point(829, 159);
            this.CbBanAn.Name = "CbBanAn";
            this.CbBanAn.Size = new System.Drawing.Size(96, 26);
            this.CbBanAn.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "Danh sách bàn ăn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(701, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chuyển bàn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1017, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số Lượng:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1149, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // FrmQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 706);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbBanAn);
            this.Controls.Add(this.numGiam);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LsvTT);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.CbMonAn);
            this.Controls.Add(this.CbDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Ăn";
            this.Load += new System.EventHandler(this.FrmQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbDanhMuc;
        private System.Windows.Forms.ComboBox CbMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.ListView LsvTT;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader SL;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.NumericUpDown numGiam;
        private System.Windows.Forms.ComboBox CbBanAn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

