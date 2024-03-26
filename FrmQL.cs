using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Data.Entity.Infrastructure;
using ZXing.QrCode.Internal;

namespace QLQuanAn
{
    public partial class FrmQL : Form
    {
        public FrmQL()
        {
            InitializeComponent();
        }
        #region Method 
        //làm đầy combo box Danh mục
        void FillCbBox()
        {
            using (QLQAEntities db = new QLQAEntities())
            {
                var result = from c in db.DanhMucs select c.TenDanhMuc;
                CbDanhMuc.DataSource = result.ToList();
            }
            CbDanhMuc.SelectedIndex = 0;
        }
        //Load bàn ăn
        void LoadBanAn()
        {
            flPanel.Controls.Clear();
            List<BanAn> banAnList = new List<BanAn>();
            using (QLQAEntities db = new QLQAEntities())
            {

                foreach (var c in db.BanAns)
                {
                    banAnList.Add(c);
                }

            }
            foreach (BanAn c in banAnList)
            {
                Button btn = new Button() { Width = 100, Height = 90 };
                btn.Click += btnBan_Click;
                btn.Tag = c;
                if (c.TrangThai == true)
                {
                    btn.BackColor = Color.LightPink;
                    btn.Text = c.TenBan + Environment.NewLine + "Có ngươi";
                }
                else
                {
                    btn.BackColor = Color.Aqua;
                    btn.Text = c.TenBan + Environment.NewLine + "Trống";
                }
                flPanel.Controls.Add(btn);

            }
          
        }
        //reset
        void Clear()
        {
            txtTongTien.Text = null;
            txtRong.Text = null;
            LsvTT.Items.Clear();
            numGiam.Value = 0;
        }
        //Load listview
        void LoadListView(int id)
        {
            using (QLQAEntities db = new QLQAEntities())
            {
                foreach (var c in db.ChiTietHoaDons)
                {
                    if (c.BanAn.BanAnID == id)//Kiểm tra ID bàn trong CSDL nào trùng với id bàn vừa chọn
                    {
                        if (c.BanAn.TrangThai == true)// kiểm tra trạng thái true == Có người
                        {
                            String[] row = { c.MonAn.TenMonAn, c.Soluong.ToString(), c.MonAn.GiaTien.ToString(), (Convert.ToInt32(c.Soluong) * Convert.ToInt32(c.MonAn.GiaTien)).ToString(), c.MonAnID };
                            LsvTT.Items.Add(new ListViewItem(row));
                            
                        }
                    }
                }
                int tong = 0;
                for(int i = 0; i<LsvTT.Items.Count; i++)
                {
                    tong += Convert.ToInt32(LsvTT.Items[i].SubItems[3].Text);
                    CultureInfo cl = new CultureInfo("vi-VN");//khai báo thêm thư viện Globalization để dùng 
                                                              //vi-VN là ký hiệu để đổi theo mệnh giá
                    txtTongTien.Text = tong.ToString("c", cl);//"c" viết tắt trong Culture đơn vị giá tiền
                    txtRong.Text = tong.ToString();
                }

            }
        }
        //làm đầy combo box bàn ăn
        void LoadCbBoxBanAn()
        {
            using (QLQAEntities db = new QLQAEntities())
            {
                var result = from c in db.BanAns select c.TenBan;
                CbBanAn.DataSource = result.ToList();
            }
            CbDanhMuc.SelectedIndex = 0;
        }

        
        #endregion
        #region Event
        //Load form
        private void FrmQL_Load(object sender, EventArgs e)
        {
            FillCbBox();
            numSoLuong.Value = 1;
            LoadBanAn();
            LoadCbBoxBanAn();
        }
        //Nạp combo box món ăn  theo id danh mục
        private void CbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QLQAEntities db = new QLQAEntities())
            {
                MonAn ma = new MonAn();
                for (int i = 0; i <= CbDanhMuc.Items.Count; i++)
                {
                    if (CbDanhMuc.SelectedIndex == i)
                    {
                        CbMonAn.Items.Clear();
                        CbMonAn.Text = "";
                        foreach (var id in db.MonAns)
                        {
                            if (id.DanhMucID == i+1) //vì index trong cbDanhMuc là từ 0 nên khi kiểm tra trong context phải +1
                            {
                                ma.TenMonAn = id.TenMonAn;
                                CbMonAn.Items.Add(ma.TenMonAn);
                            }
                        }
                        CbMonAn.SelectedIndex = 0;
                    }
                }
            }
        }
        //Hiển thị chi tiết hóa đơn, tổng tiền, trạng thái bàn theo từng bàn
        private void btnBan_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).BanAnID; // lấy id bàn ăn 
            label6.Text ="Bàn " + id.ToString();
            Clear();
            LoadListView(id);
        }
        //thêm món
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hd = new HoaDon();
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.BanAnID = Convert.ToInt32(label6.Text.Substring(3)); // Lấy ID bàn
                if (numSoLuong.Value == 0)//kiểm tra số lượng
                {
                    MessageBox.Show("không thể thêm món khi số lượng là 0");
                    numSoLuong.Focus();
                    return;
                }
                else
                {
                    ct.Soluong = Convert.ToInt32(numSoLuong.Value);
                    //lấy ID món ăn qua combobox
                    using (QLQAEntities db = new QLQAEntities())
                    {
                        
                        foreach (var c in db.MonAns)
                        {
                            if (c.TenMonAn == CbMonAn.Text) //tìm tên món ăn trong CSDL == tên món trong comboBox
                            {
                                ct.MonAnID = c.MonAnID;//lấy id món
                            }
                        }
                        foreach (var c in db.BanAns)
                        {
                            
                            if (c.BanAnID == Convert.ToInt32(label6.Text.Substring(3)))
                            {
                                c.TrangThai = true;//chuyển trạng thái
                            }
                        }
                        hd.BanAnID = Convert.ToInt32(label6.Text.Substring(3));
                        db.ChiTietHoaDons.Add(ct);
                        db.HoaDons.Add(hd);
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm món");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! không xác nhận được bàn ăn");
            }
            LsvTT.Items.Clear();
            LoadBanAn();
            LoadListView(Convert.ToInt32(label6.Text.Substring(3)));
        }
        //huy món
        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn hủy món ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (QLQAEntities db = new QLQAEntities())
                    {
                        int id = Convert.ToInt32(label6.Text.Substring(3));//lấy id bàn ăn cần thanh toán
                        string idm  =  LsvTT.SelectedItems[0].SubItems[4].Text.ToString();//lấy id món ăn
                        var models = db.ChiTietHoaDons.FirstOrDefault(x => x.BanAnID == id);//tìm id bàn ăn trong csdl = id bàn thanh toán
                        if (models != null && models.MonAnID == idm)//kiểm tra món ăn trong bàn đó nếu có
                        {
                            db.ChiTietHoaDons.Remove(models);//xóa chi tiết hóa đơn
                            db.SaveChanges();
                            MessageBox.Show("Hủy món thành công");
                        }
                    }
                }
                    
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            LsvTT.Items.Clear();
            LoadListView(Convert.ToInt32(label6.Text.Substring(3)));

        }
        //thanh toán,lưu hóa đơn, lưu tổng tiền và giảm giá theo bàn
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thanh toán", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               try
               {
                    int giam = (int)numGiam.Value;                    
                    int total = Convert.ToInt32(txtRong.Text);
                    using (QLQAEntities db = new QLQAEntities())
                    {
                        for (int i = 0; i < LsvTT.Items.Count; i++)
                        {
                            
                            int id = Convert.ToInt32(label6.Text.Substring(3));//lấy id bàn
                            var models = db.ChiTietHoaDons.FirstOrDefault(x => x.BanAnID == id);//tìm bàn
                            if (models != null)
                            {
                                foreach (var c in db.HoaDons)
                                {
                                    if (id == c.BanAnID && c.TongTien == null)// lưu hóa đơn
                                    {
                                        c.BanAn.TrangThai = false;// chuyển trạng thái bàn
                                        c.GiamGia = giam.ToString();//lưu giảm giá
                                        c.TongTien = total + (total * giam/100);//tính và lưu tổng tiền
                                        c.Ngay = DateTime.Now.Date;//lưu ngày lập hóa đơn
                                    }
                                }
                                db.ChiTietHoaDons.Remove(models);
                                db.SaveChanges();
                            }
                        }
                        LsvTT.Items.Clear();
                        LoadBanAn();
                        LoadListView(Convert.ToInt32(label6.Text.Substring(3)));
                    }
                }
                catch
                {
                    MessageBox.Show("Bàn đang trống hoặc không có món để thanh toán","Thông báo",MessageBoxButtons.OK);
                }
            }
        }
        //thoát
        private void pictureBox1_Click(object sender, EventArgs e) => Application.Exit();
        //chuyển bàn
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int id1 = Convert.ToInt32(label6.Text.Substring(3)); //lấy id (1) bàn cần chuyển 
            int id2 = CbBanAn.SelectedIndex + 1; //lấy id (2) bàn muốn chuyển đến 
            ChiTietHoaDon models = new ChiTietHoaDon();
            using (QLQAEntities db = new QLQAEntities())
            {
                for (int i = 0; i < LsvTT.Items.Count; i++)
                {
                      models = db.ChiTietHoaDons.FirstOrDefault(x => x.BanAnID == id1);
                      if (models.MonAnID == LsvTT.Items[i].SubItems[4].Text.ToString())
                      {
                            models.BanAn.TrangThai = false; //đổi trạng thái bàn id 1
                            models.BanAnID = id2;//thay id bàn 1 sang bàn 2
                            models.HoaDon.BanAnID = id2;//thay id hoa don ban 1 sang id 2
                            db.SaveChanges();
                            models = db.ChiTietHoaDons.FirstOrDefault(x => x.BanAnID == id2);//tìm id bàn ăn = id2
                            models.BanAn.TrangThai = true; // đổi trạng thái bàn 2
                            db.Entry(models).State = EntityState.Modified;
                            db.SaveChanges();
                      }
                }
                MessageBox.Show("Chuyển bàn thành công !!");
            }
            Clear();
            LoadBanAn();
            LoadListView(id1);
        }
        //Đăng xuất
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
            this.Close();
        }
        #endregion


    }
}
