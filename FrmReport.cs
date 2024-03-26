using Microsoft.Reporting.WinForms;
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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            QLQAEntities dbcontext = new QLQAEntities();
            List<HoaDon> danhsach = dbcontext.HoaDons.ToList();
            this.rpvThongKe.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", danhsach);
            this.rpvThongKe.LocalReport.DataSources.Clear();
            this.rpvThongKe.LocalReport.DataSources.Add(reportDataSource);
            this.rpvThongKe.RefreshReport();
            this.rpvThongKe.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
