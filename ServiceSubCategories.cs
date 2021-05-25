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
    public partial class ServiceSubCategories : Form
    {
        public ServiceSubCategories()
        {
            InitializeComponent();
        }

        private void ServiceSubCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.ServicesSubCategories' table. You can move, or remove it, as needed.
            this.servicesSubCategoriesTableAdapter.Fill(this.transnational_Auto_3DataSet.ServicesSubCategories);

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            servicesSubCategoriesBindingSource.Filter = "description like '%" + txtsearch.Text + "%'";
        }
    }
}
