namespace QLQuanAn
{
    partial class FrmQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQR));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnQuet = new System.Windows.Forms.Button();
            this.btnWC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Visible = false;
            // 
            // btnQuet
            // 
            this.btnQuet.Location = new System.Drawing.Point(185, 348);
            this.btnQuet.Name = "btnQuet";
            this.btnQuet.Size = new System.Drawing.Size(85, 36);
            this.btnQuet.TabIndex = 2;
            this.btnQuet.Text = "Quét";
            this.btnQuet.UseVisualStyleBackColor = true;
            this.btnQuet.Click += new System.EventHandler(this.btnQuet_Click);
            // 
            // btnWC
            // 
            this.btnWC.Location = new System.Drawing.Point(60, 348);
            this.btnWC.Name = "btnWC";
            this.btnWC.Size = new System.Drawing.Size(85, 36);
            this.btnWC.TabIndex = 2;
            this.btnWC.Text = "Web Cam";
            this.btnWC.UseVisualStyleBackColor = true;
            this.btnWC.Click += new System.EventHandler(this.btnWC_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnWC);
            this.Controls.Add(this.btnQuet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQR_FormClosing);
            this.Load += new System.EventHandler(this.FrmQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnQuet;
        private System.Windows.Forms.Button btnWC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}