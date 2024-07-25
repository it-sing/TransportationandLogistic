using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationandLogistic.Forms
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnBookingReport_Click(object sender, EventArgs e)
        {
            FrmBookingReport BookingReportForm = new FrmBookingReport();
            BookingReportForm.Show();
        }

        private void btnInvoiceReport_Click(object sender, EventArgs e)
        {
            FrmPackageReport PackageReportForm = new FrmPackageReport();
            PackageReportForm.Show();

        }
    }
}
