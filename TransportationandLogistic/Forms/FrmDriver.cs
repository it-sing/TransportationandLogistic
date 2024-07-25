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
    public partial class FrmDriver : Form
    {
        public FrmDriver()
        {
            InitializeComponent();

            this.Size = new Size(1848, 1364);
        }

        private void FrmDriver_Load(object sender, EventArgs e)
        {

        }

        private void btnDriverLogistic_Click(object sender, EventArgs e)
        {
            FrmDriverLogistic DriverLogisticForm = new FrmDriverLogistic();
            DriverLogisticForm.Show();
            DriverLogisticForm.Size = new Size(2300, 1500);

        }

        private void btnDriverTransport_Click(object sender, EventArgs e)
        {
            FrmDriverTransport DriverTransportForm = new FrmDriverTransport();
            DriverTransportForm.Show();
            DriverTransportForm.Size = new Size(2300, 1500);
        }
    }
}
