namespace QLQuanAn
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnBanAn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(326, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 71);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.BackgroundImage")));
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.Location = new System.Drawing.Point(249, 335);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(76, 71);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNV.BackgroundImage")));
            this.btnNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.ForeColor = System.Drawing.Color.Black;
            this.btnNV.Location = new System.Drawing.Point(17, 229);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(226, 177);
            this.btnNV.TabIndex = 4;
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Location = new System.Drawing.Point(249, 154);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(154, 175);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.LightYellow;
            this.btnDoanhThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.BackgroundImage")));
            this.btnDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.Location = new System.Drawing.Point(249, 29);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(154, 119);
            this.btnDoanhThu.TabIndex = 2;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnBanAn
            // 
            this.btnBanAn.BackColor = System.Drawing.Color.LightGreen;
            this.btnBanAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBanAn.BackgroundImage")));
            this.btnBanAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanAn.Location = new System.Drawing.Point(17, 29);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Size = new System.Drawing.Size(226, 193);
            this.btnBanAn.TabIndex = 1;
            this.btnBanAn.Text = "Bàn Ăn";
            this.btnBanAn.UseVisualStyleBackColor = false;
            this.btnBanAn.Click += new System.EventHandler(this.btnBanAn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Controls.Add(this.btnNV);
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.btnDoanhThu);
            this.groupBox1.Controls.Add(this.btnBanAn);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 423);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(474, 484);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanAn;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}