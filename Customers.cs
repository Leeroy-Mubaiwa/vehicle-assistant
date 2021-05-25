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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.transnational_Auto_3DataSet.Customers);

        }
        private void Customers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string t = txtsearch.Text;
            customersBindingSource.Filter = "id_number like '%"+t+ "%' or name like '%" + t + "%' or phone like '%" + t + "%' or address like '%" + t + "%' or email like '%" + t + "%'";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch.Text.Length<3)
            {
                customersBindingSource.RemoveFilter();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = (int)servicesDatagridView.CurrentRow.Cells[0].Value;
            customersBindingSource.RemoveCurrent();
            customersBindingSource.EndEdit();
            vehiclesTableAdapter1.DeleteQueryVeh(id);
            customersTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
            loadData();
        }

        private void btnsaveall_Click(object sender, EventArgs e)
        {
            this.Validate();
            customersBindingSource.EndEdit();
            customersTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
            loadData();
        }
    }
}
