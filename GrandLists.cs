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
    public partial class GrandLists : Form
    {
        public GrandLists()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);

        }

        private void GrandLists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Quotation_Description' table. You can move, or remove it, as needed.
            this.quotation_DescriptionTableAdapter.Fill(this.transnational_Auto_3DataSet.Quotation_Description);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoice_Description' table. You can move, or remove it, as needed.
            this.invoice_DescriptionTableAdapter.Fill(this.transnational_Auto_3DataSet.Invoice_Description);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Quotation' table. You can move, or remove it, as needed.
            this.quotationTableAdapter.Fill(this.transnational_Auto_3DataSet.Quotation);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.transnational_Auto_3DataSet.Invoices);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.transnational_Auto_3DataSet.Vehicles);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.transnational_Auto_3DataSet.Customers);

        }
    }
}
