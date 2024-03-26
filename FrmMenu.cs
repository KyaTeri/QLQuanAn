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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        #region method
        void Clear()
        {
            txtMa.Clear();
            txtTen.Clear();
            using (QLQAEntities db = new QLQAEntities())
            {
                var result = from c in db.DanhMucs select c.TenDanhMuc;
                cbDanhMuc.DataSource = result.ToList();
            }
            cbDanhMuc.SelectedIndex = 0;
            txtGia.Clear();
        }
        void Populate()
        {
            lsvMenu.Items.Clear();
            lsvMenu.View = View.Details;

            using (QLQAEntities db = new QLQAEntities())
            {
                foreach (var s in db.MonAns)
                {
                    String[] row = { s.MonAnID.ToString(), s.TenMonAn, s.DanhMuc.TenDanhMuc, s.GiaTien.ToString() };
                    lsvMenu.Items.Add(new ListViewItem(row));
                }
            }
        }
        #endregion
        #region event
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Clear();
            Populate();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonAn model = new MonAn();
            model.MonAnID = txtMa.Text.Trim();
            model.TenMonAn = txtTen.Text.Trim();
            model.DanhMucID = Convert.ToInt32(cbDanhMuc.SelectedIndex + 1);
            model.GiaTien = int.Parse(txtGia.Text.Trim());
            using (QLQAEntities db = new QLQAEntities())
            {
                db.MonAns.Add(model);
                db.SaveChanges();
            }
            Clear();
            Populate();
            MessageBox.Show("Đã thêm vào Menu");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvMenu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng dữ liệu cần cập nhật");
                return;
            }
            MonAn model = new MonAn();
            using (QLQAEntities db = new QLQAEntities())
            {
                String id = lsvMenu.Items[lsvMenu.FocusedItem.Index].SubItems[0].Text.ToString();
                model = db.MonAns.SingleOrDefault(x => x.MonAnID == id);
                model.TenMonAn = txtTen.Text.Trim();
                model.DanhMucID = Convert.ToInt32(cbDanhMuc.SelectedIndex + 1);
                model.GiaTien = int.Parse(txtGia.Text.Trim());
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            Populate();
            MessageBox.Show("Đã sửa thông tin món ăn!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvMenu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng dữ liệu cần xóa!");
                return;
            }
            if (MessageBox.Show("Có muốn xóa khỏi Menu?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QLQAEntities db = new QLQAEntities())
                {
                    String id = lsvMenu.Items[lsvMenu.FocusedItem.Index].SubItems[0].Text.ToString();
                    var model1 = db.MonAns.SingleOrDefault(x => x.MonAnID == id);
                    if (model1 != null)
                    {
                        db.MonAns.Remove(model1);
                        db.SaveChanges();
                        Clear();
                        Populate();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
        }
        private void lsvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMa.Text = lsvMenu.Items[lsvMenu.FocusedItem.Index].SubItems[0].Text;
            txtTen.Text = lsvMenu.Items[lsvMenu.FocusedItem.Index].SubItems[1].Text;
            cbDanhMuc.SelectedIndex = cbDanhMuc.FindString(lsvMenu.Items[lsvMenu.FocusedItem.Index].SubItems[2].Text);
            txtGia.Text = lsvMenu.Items[lsvMenu.FocusedItem.Index].SubItems[3].Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Close();
        }
        #endregion
    }
}
