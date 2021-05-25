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
    public partial class Vehicles_Only : Form
    {
        public Vehicles_Only()
        {
            InitializeComponent();
        }

        private void Vehicles_Only_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.transnational_Auto_3DataSet.Vehicles);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string t = txtsearch.Text;
            vehiclesBindingSource.Filter = "reg_number like '%" + t + "%' or engine_number like '%" + t + "%' or chasis_number like '%" + t + "%' or model like '%" + t + "%' or make like '%" + t+"%'";

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch.Text.Length<3)
            {
                vehiclesBindingSource.RemoveFilter();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            vehiclesBindingSource.RemoveCurrent();
            vehiclesBindingSource.EndEdit();
            vehiclesTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
        }

        private void btnsaveall_Click(object sender, EventArgs e)
        {
            this.Validate();
            vehiclesBindingSource.EndEdit();
            vehiclesTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
        }
    }
}
