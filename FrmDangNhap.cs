using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLQuanAn
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        #region method
        void DangNhap()
        {
            using (QLQAEntities db = new QLQAEntities())
            {
                var c = db.Accounts.Where(a => a.TaiKhoan == txtTK.Text && a.MatKhau == txtMK.Text).FirstOrDefault();
                if (c != null)
                {
                    if(c.TaiKhoanID == 1)
                    {
                        FrmMain f = new FrmMain();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmQL f = new FrmQL();
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập");
                    txtTK.Focus();
                }
                
            }
        }
        #endregion
        #region event
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
            
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmQR frm = new FrmQR();
            frm.Show();
            this.Hide();
        }
        #endregion
    }
}
