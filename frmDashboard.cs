using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vehicle_Service_Software
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        public void defaultDisplay()
        {
            timeTimer.Start();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            defaultDisplay();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }
    }
}
