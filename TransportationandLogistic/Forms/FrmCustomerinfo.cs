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
    public partial class FrmCustomerinfo : Form
    {
        public FrmCustomerinfo()
        {
            InitializeComponent();
            this.Size = new Size(1848, 1364);
        }

        private void btnCustomerBookinginfo_Click(object sender, EventArgs e)
        {
            FrmCustomerBookingDetail CustomerBookingDetailForm = new FrmCustomerBookingDetail();
            CustomerBookingDetailForm.Show();
            CustomerBookingDetailForm.Size = new Size(2500, 1700);
        }

        private void btnCustomerPackageDetail_Click(object sender, EventArgs e)
        {
            FrmCustomerPackageDetail CustomerPackageDetailForm = new FrmCustomerPackageDetail();
            CustomerPackageDetailForm.Show();
            CustomerPackageDetailForm.Size = new Size(2500, 1700);

        }
    }
}
