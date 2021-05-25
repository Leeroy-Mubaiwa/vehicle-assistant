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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }
        
        private void Services_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.ServicesSubCategories' table. You can move, or remove it, as needed.
            this.servicesSubCategoriesTableAdapter.Fill(this.transnational_Auto_3DataSet.ServicesSubCategories);
            loadData();
        }
        public void loadData()
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.transnational_Auto_3DataSet.Services);

        }
        private void servicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void btnservices_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);

        
        }

        private void btnnewservice_Click(object sender, EventArgs e)
        {
            servicesBindingSource.AddNew();
            company_codeTextBox.Text = "1";
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)servicesDatagridView.CurrentRow.Cells[0].Value;
                int company_code = (int)servicesDatagridView.CurrentRow.Cells[2].Value;
             servicesSubCategoriesTableAdapter.DeleteServiceChildren(id);
                servicesTableAdapter.Delete(id, company_code);

                
            }
            catch
            {

            }
            loadData();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            servicesBindingSource.Filter = "description like '%"+txtsearch.Text+"%'";
        }
    }
}
