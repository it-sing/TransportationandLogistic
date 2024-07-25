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
    public partial class FrmService : Form
    {
        public FrmService()
        {
            InitializeComponent();
            this.Size = new Size(1848, 1364);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // Instantiate the FrmBookinginfo form
            FrmBookinginfo bookingInfoForm = new FrmBookinginfo();

            // Show the form as a modeless dialog
            bookingInfoForm.Show();
            bookingInfoForm.Size = new Size(2300, 1700);


        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            FrmPackageinfo PackageinfoForm = new FrmPackageinfo();

            // Show the form as a modeless dialog
            PackageinfoForm.Show();
            PackageinfoForm.Size = new Size(2300, 1700);

        }
    }
}
