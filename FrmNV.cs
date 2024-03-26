using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanAn
{
    public partial class FrmNV : Form
    {
        public FrmNV()
        {
            InitializeComponent();
        }
        #region event
        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng dữ liệu cần xóa!");
                return;
            }
            if (MessageBox.Show("Có muốn xóa khỏi Menu?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QLQAEntities db = new QLQAEntities())
                {
                    String id = lsvNV.Items[lsvNV.FocusedItem.Index].SubItems[0].Text.ToString();
                    var model1 = db.NhanViens.SingleOrDefault(x => x.MaNV == id);
                    if (model1 != null)
                    {
                        db.NhanViens.Remove(model1);
                        db.SaveChanges();
                        Clear();
                        Populate();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng dữ liệu cần cập nhật");
                return;
            }
            NhanVien model = new NhanVien();
            using (QLQAEntities db = new QLQAEntities())
            {
                String id = lsvNV.Items[lsvNV.FocusedItem.Index].SubItems[0].Text.ToString();
                model = db.NhanViens.SingleOrDefault(x => x.MaNV == id);
                model.TenNV = txtTen.Text.Trim();
                model.SDT = txtSDT.Text.Trim();
                model.DiaChi = txtDC.Text.Trim();
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            Populate();
            MessageBox.Show("Đã sửa thông tin NV");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien model = new NhanVien();
            model.MaNV = txtMa.Text.Trim();
            model.TenNV = txtTen.Text.Trim();
            model.SDT = txtSDT.Text.Trim();
            model.DiaChi = txtDC.Text.Trim();
            using (QLQAEntities db = new QLQAEntities())
            {
                db.NhanViens.Add(model);
                db.SaveChanges();
            }
            Clear();
            Populate();
            MessageBox.Show("Đã thêm vào danh sách nhân viên");
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMa.Text = lsvNV.Items[lsvNV.FocusedItem.Index].SubItems[0].Text;
            txtTen.Text = lsvNV.Items[lsvNV.FocusedItem.Index].SubItems[1].Text;
            txtSDT.Text = lsvNV.Items[lsvNV.FocusedItem.Index].SubItems[2].Text;
            txtDC.Text = lsvNV.Items[lsvNV.FocusedItem.Index].SubItems[3].Text;
        }
        private void FrmNV_Load(object sender, EventArgs e)
        {
            Clear();
            Populate();
        }
        
        #endregion

        #region method
        void Populate()
        {
            lsvNV.Items.Clear();
            lsvNV.View = View.Details;

            using (QLQAEntities db = new QLQAEntities())
            {
                foreach (var s in db.NhanViens)
                {
                    String[] row = { s.MaNV, s.TenNV, s.SDT, s.DiaChi };
                    lsvNV.Items.Add(new ListViewItem(row));
                }
            }
        }
        void Clear()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDC.Clear();
        }

        #endregion

        
    }
}
