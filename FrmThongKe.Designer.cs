namespace QLQuanAn
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.IdHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu ngày:";
            // 
            // dt
            // 
            this.dt.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dt.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dt.CustomFormat = "dd/MM/yyyy";
            this.dt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(155, 53);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(120, 26);
            this.dt.TabIndex = 1;
            this.dt.Value = new System.DateTime(2022, 10, 16, 21, 21, 58, 0);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Transparent;
            this.btnTroVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTroVe.BackgroundImage")));
            this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroVe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTroVe.Location = new System.Drawing.Point(730, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(57, 43);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.BackColor = System.Drawing.Color.White;
            this.txtDoanhThu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(466, 53);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(115, 26);
            this.txtDoanhThu.TabIndex = 3;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // dgvTK
            // 
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHD,
            this.TenBan,
            this.GiamGia,
            this.Tong,
            this.Ngay,
            this.TrangThai});
            this.dgvTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTK.Location = new System.Drawing.Point(0, 99);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(799, 351);
            this.dgvTK.TabIndex = 5;
            // 
            // IdHD
            // 
            this.IdHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdHD.HeaderText = "Hóa đơn";
            this.IdHD.MinimumWidth = 6;
            this.IdHD.Name = "IdHD";
            this.IdHD.Visible = false;
            this.IdHD.Width = 125;
            // 
            // TenBan
            // 
            this.TenBan.HeaderText = "Tên Bàn";
            this.TenBan.MinimumWidth = 6;
            this.TenBan.Name = "TenBan";
            this.TenBan.Width = 125;
            // 
            // GiamGia
            // 
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.MinimumWidth = 6;
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Width = 60;
            // 
            // Tong
            // 
            this.Tong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tong.HeaderText = "Tổng tiền (đã giảm giá)";
            this.Tong.MinimumWidth = 6;
            this.Tong.Name = "Tong";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 89;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Transparent;
            this.btnTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTim.BackgroundImage")));
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTim.Location = new System.Drawing.Point(281, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(34, 30);
            this.btnTim.TabIndex = 2;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.RosyBrown;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(647, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(34, 29);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXoa;
    }
}