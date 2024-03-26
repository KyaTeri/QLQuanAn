using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace QLQuanAn
{
    public partial class FrmQR : Form
    {
        public FrmQR()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private void FrmQR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();  
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void btnWC_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();

                if (decoded == "Admin")
                {
                    timer1.Stop();
                    FrmMain form = new FrmMain();
                    form.Show();
                    this.Close();
                }
                else if(decoded == "NhanVien")
                {
                    timer1.Stop();
                    FrmQL form = new FrmQL();
                    form.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnQuet_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void FrmQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
            this.Close();
        }
    }
}
