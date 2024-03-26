using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanAn
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        #region event
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnBanAn_Click(object sender, EventArgs e)
        {
            FrmBanAn f = new FrmBanAn();
            f.Show();
            this.Hide();
            
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            f.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu f = new FrmMenu();
            f.Show();
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
            this.Close();
        }
        private void btnNV_Click(object sender, EventArgs e)
        {
            FrmNV f = new FrmNV();
            f.Show();
            this.Close();

        }
        #endregion

    }
}
