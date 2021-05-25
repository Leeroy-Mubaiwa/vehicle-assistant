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
    public partial class Customer_Vehicles : Form
    {
        public Customer_Vehicles()
        {
            InitializeComponent();
        }

        private void btnnewservice_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            cs.ShowDialog();

            loadData();
        }

        private void btnSearch_Service_Click(object sender, EventArgs e)
        {
            string t = txtsearch_service.Text;
            vehiclesBindingSource.Filter = "reg_number like '%" + t + "%' or engine_number like '%" + t + "%' or chasis_number like '%" + t + "%' or model like '%" + t + "%' or make like '%" + t + "%'";
            int a = vehiclesBindingSource.Count;
            if(a==1)
            {
                lblfoundnumber.Text = "Found " + a + " vehicle";
            }
            else
            {
                lblfoundnumber.Text = "Found " + a + " vehicles";
            }
            
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.transnational_Auto_3DataSet.Vehicles);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.transnational_Auto_3DataSet.Customers);
        }
        private void Customer_Vehicles_Load(object sender, EventArgs e)
        {
            timer1.Start();
            loadData();
        }

        private void btnimage_vehicle_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Scanned Images  (*.png) ;(*.jpg); (*.jpeg);| *.png; *.jpeg; *jpg";
                opf.Title = "Choose a scanned picture or normal picture of signature";
                opf.ShowDialog();
                string picture = opf.FileName;
                imagePictureBox.Image = Image.FromFile(picture);
            }
            catch (Exception pictre)
            {
                MessageBox.Show(pictre.Message + " \n \n " + pictre.StackTrace)
;
            }
        }

        private void txtsearch_service_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch_service.Text.Length<3)
            {
                vehiclesBindingSource.RemoveFilter();
                int a = vehiclesBindingSource.Count;
                if (a == 1)
                {
                    lblfoundnumber.Text = "Found " + a + " vehicle";
                }
                else
                {
                    lblfoundnumber.Text = "Found " + a + " vehicles";
                }
            }
        }

        private void btndeleteSelected_Click(object sender, EventArgs e)
        {
            vehiclesBindingSource.RemoveCurrent();
            vehiclesBindingSource.EndEdit();
            vehiclesTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
        }

        private void btnSaveSubCategories_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                vehiclesBindingSource.EndEdit();
                vehiclesTableAdapter.Update(transnational_Auto_3DataSet);
                tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void newVehcile(object sender, EventArgs e)
        {
            vehiclesBindingSource.AddNew();
            
        }

        private void btnall_vehicles(object sender, EventArgs e)
        {
            Vehicles_Only vh = new Vehicles_Only();
            vh.Show();
            loadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //loadData();
        }
    }
}
