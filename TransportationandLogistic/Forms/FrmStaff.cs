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
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
            this.Size = new Size(1848, 1364);
        }

        private void btnStaffInfo_Click(object sender, EventArgs e)
        {
            FrmStaffInfo StaffInfoForm = new FrmStaffInfo();
            StaffInfoForm.Show();
            StaffInfoForm.Size = new Size(2000, 1500);
        }

        private void btnStaffPaywage_Click(object sender, EventArgs e)
        {
            FrmStaffPaywage StaffPaywageForm = new FrmStaffPaywage();
            StaffPaywageForm.Show();
            StaffPaywageForm.Size = new Size(2000, 1500);
        }
    }
}
