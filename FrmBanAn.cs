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
    public partial class FrmBanAn : Form
    {
        public FrmBanAn()
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
            if (lsvBan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng dữ liệu cần xóa!");
                return;
            }
            if (MessageBox.Show("Có muốn xóa khỏi danh sach ban?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QLQAEntities db = new QLQAEntities())
                {
                    int id = Convert.ToInt32(lsvBan.Items[lsvBan.FocusedItem.Index].SubItems[0].Text.ToString());
                    var model1 = db.BanAns.SingleOrDefault(x => x.BanAnID == id);
                    if (model1 != null)
                    {
                        db.BanAns.Remove(model1);
                        db.SaveChanges();
                        Clear();
                        Populate();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BanAn model = new BanAn();
            model.BanAnID = Convert.ToInt32(txtMa.Text.Trim());
            model.TenBan = txtTen.Text.Trim();
            using (QLQAEntities db = new QLQAEntities())
            {
                db.BanAns.Add(model);
                db.SaveChanges();
            }
            Clear();
            Populate();
            MessageBox.Show("Đã thêm bàn ăn");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvBan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng dữ liệu cần cập nhật");
                return;
            }
            BanAn model = new BanAn();
            using (QLQAEntities db = new QLQAEntities())
            {
                int id = Convert.ToInt32(lsvBan.Items[lsvBan.FocusedItem.Index].SubItems[0].Text.ToString());
                model = db.BanAns.SingleOrDefault(x => x.BanAnID == id);
                model.TenBan = txtTen.Text.Trim();
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            Populate();
            MessageBox.Show("Đã sửa thông tin bàn ăn!");
        }
        private void FrmBanAn_Load(object sender, EventArgs e)
        {
            Clear();
            Populate();
        }
        private void lsvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMa.Text = lsvBan.Items[lsvBan.FocusedItem.Index].SubItems[0].Text;
            txtTen.Text = lsvBan.Items[lsvBan.FocusedItem.Index].SubItems[1].Text;
        }
        #endregion
        #region method
        void Clear()
        {
            txtMa.Clear();
            txtTen.Clear();
        }
        void Populate()
        {
            lsvBan.Items.Clear();
            lsvBan.View = View.Details;

            using (QLQAEntities db = new QLQAEntities())
            {
                foreach (var s in db.BanAns)
                {
                    String[] row = { s.BanAnID.ToString(), s.TenBan };
                    lsvBan.Items.Add(new ListViewItem(row));
                }
            }
        }
        #endregion


    }
}
