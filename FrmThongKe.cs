using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanAn
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }
        #region method
        //nạp dataGridView
        private void HienThi()
        {
            dgvTK.Rows.Clear();
            using (QLQAEntities db = new QLQAEntities())
            {
                foreach (var c in db.HoaDons)
                {
                    int i = dgvTK.Rows.Add();
                    dgvTK.Rows[i].Cells[1].Value = c.BanAn.TenBan;
                    dgvTK.Rows[i].Cells[2].Value = c.GiamGia;
                    dgvTK.Rows[i].Cells[3].Value = c.TongTien;
                    dgvTK.Rows[i].Cells[4].Value = c.Ngay;
                    if (c.TongTien == null)
                        dgvTK.Rows[i].Cells[5].Value = "Hủy";
                    else
                        dgvTK.Rows[i].Cells[5].Value = "Nhận";
                }
            }
        }
        //kiểm tra DataGridView có dòng lặp không? nếu có xóa dòng lặp
        private void Ktr(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {

                string TenBan = dataGridView.Rows[i].Cells[1].Value.ToString();
                int Giamgia = Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                int TongTien = Convert.ToInt32(dataGridView.Rows[i].Cells[3].Value);
                DateTime Ngay = Convert.ToDateTime(dataGridView.Rows[i].Cells[4].Value);

                for (int j = 0; j<dataGridView.Rows.Count -1 ; j++)
                {
                    string tb = dataGridView.Rows[j].Cells[1].Value.ToString();
                    int gg = Convert.ToInt32(dataGridView.Rows[j].Cells[2].Value);
                    int tt = Convert.ToInt32(dataGridView.Rows[j].Cells[3].Value);
                    DateTime n = Convert.ToDateTime(dataGridView.Rows[j].Cells[4].Value);
                    if (i != j)
                    {
                        if (TenBan == tb && Ngay == n && gg == Giamgia && tt == TongTien)
                        {
                            dataGridView.Rows.RemoveAt(j);
                            break;
                        }
                    }
                }
            }
        }
        //Hiện tổng doanh thu lên text box       
        void TongDoanhThu()
        {
            int tong = 0;
            for (int i =0; i < dgvTK.Rows.Count; i++)
            {
                int t = Convert.ToInt32(dgvTK.Rows[i].Cells["Tong"].Value);
                tong += t;
            }
            CultureInfo cl = new CultureInfo("vi-VN");
            txtDoanhThu.Text = tong.ToString("c",cl);
        }
        #endregion
        #region event
        //Load
        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            HienThi();
            Ktr(dgvTK);
            TongDoanhThu();
        }
        //về form QL
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Close();
        }
        //Tìm kiếm theo ngày
        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime s = dt.Value.Date;
            dgvTK.Rows.Clear();
            using (QLQAEntities db = new QLQAEntities())
            {
                foreach(var c in db.HoaDons)
                {
                    
                    if (s == c.Ngay)
                    {
                        int i = dgvTK.Rows.Add();
                        dgvTK.Rows[i].Cells[1].Value = c.BanAn.TenBan;
                        dgvTK.Rows[i].Cells[2].Value = c.GiamGia;
                        dgvTK.Rows[i].Cells[3].Value = c.TongTien;
                        dgvTK.Rows[i].Cells[4].Value = c.Ngay;
                        if (c.TongTien == null)
                            dgvTK.Rows[i].Cells[5].Value = "Hủy";
                        else
                            dgvTK.Rows[i].Cells[5].Value = "Nhận";
                    }
                }
            }
            Ktr(dgvTK);
            TongDoanhThu();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLQAEntities db = new QLQAEntities())
            {

                int id = Convert.ToInt32(dgvTK.CurrentRow.Cells["idHD"].Value);
                var models = db.HoaDons.FirstOrDefault(x => x.HoaDonID == id);
                if (models != null)
                {
                    db.HoaDons.Remove(models);
                    db.SaveChanges();
                }
                dgvTK.Rows.Clear();
                HienThi();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmReport f = new FrmReport();
            f.ShowDialog();
        }
        #endregion

        
    }
}
