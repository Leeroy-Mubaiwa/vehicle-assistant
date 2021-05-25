using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transnational_Auto_3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbltime.Text = dateTime.ToLongTimeString();
            
           if(dateTime.TimeOfDay.Hours>=12 && dateTime.Hour<=18)
            {
                lblgreeting.Text = "Good afternoon";
            }
           else
                if(dateTime.Hour>18)
            {
                lblgreeting.Text = "Good evening, hope you had a good day";
            }else
            {
                lblgreeting.Text = "Good morning, hope you ready for day!!";
            }
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void lblgreeting_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string password = Properties.Settings.Default.Password;
            string username = Properties.Settings.Default.Username;


            if (txtpassword.Text == password && txtusername.Text == username )
            {
                CompanyManager cm = new CompanyManager();
                cm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong details. Try again");
            }
        }
    }
}
