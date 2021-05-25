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
    public partial class Quotations : Form
    {
        public Quotations()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Quotations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Quotation_Description' table. You can move, or remove it, as needed.
            this.quotation_DescriptionTableAdapter.Fill(this.transnational_Auto_3DataSet.Quotation_Description);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Quotation_Description' table. You can move, or remove it, as needed.
            this.quotation_DescriptionTableAdapter.Fill(this.transnational_Auto_3DataSet.Quotation_Description);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Quotation' table. You can move, or remove it, as needed.
            this.quotationTableAdapter.Fill(this.transnational_Auto_3DataSet.Quotation);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.transnational_Auto_3DataSet.Vehicles);
            timer1.Start();

        }

        private void btnnewquotation_Click(object sender, EventArgs e)
        {
            quotationBindingSource.AddNew();
        }


        private void btnsave_all_Click(object sender, EventArgs e)
        {
            this.Validate();
            quotationBindingSource.EndEdit();
            quotationTableAdapter.Update(transnational_Auto_3DataSet);
            quotation_DescriptionBindingSource.EndEdit();
            quotation_DescriptionTableAdapter.Update(transnational_Auto_3DataSet.Quotation_Description);
                
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);

        }
        static int ID;
        static public void s_getID(int id)
        {
            ID = id;
        }
        public void addTotal()
        {
            try
            {
                double selected_1 = 0;
                double selected_2 = 0;
                double selected_total = 0;
                double total = 0;

                int rows = quotation_datagrid.Rows.Count;
                for (int a = 0; a < rows - 1; a++)
                {
                    try
                    {

                        selected_1 = (double)quotation_datagrid.Rows[a].Cells[4].Value;
                        selected_2 = (int)quotation_datagrid.Rows[a].Cells[2].Value;
                        selected_total = selected_1 * selected_2;
                    }
                    catch
                    {
                       // quotation_datagrid.Rows[a].Cells[5].Value = 0;
                        selected_total = 0;
                    }

                    total += selected_total;
                    quotation_datagrid.Rows[a].Cells[5].Value = selected_total;
                    btntotal.Text = Math.Round(total, 2).ToString();
                }
            }
            catch
            {
               // MessageBox.Show(er.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            addTotal();
        }

        private void quotation_datagrid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                //authenticationdataGrid.CurrentCell == authenticationdataGrid.CurrentRow.Cells[0] && company_codeTextBox1.Text != "" &&
                // authenticationdataGrid.CurrentRow.Index < authenticationdataGrid.Rows.Count
                if (quotation_datagrid.CurrentCell == quotation_datagrid.CurrentRow.Cells[1])
                {
                    ServiceSubCategories services = new ServiceSubCategories();
                    services.ShowDialog();
                    s_getID(ID);
                }
            }
            catch
            {

            }
        }

        private void btndeletecurrent(object sender, EventArgs e)
        {
            quotation_DescriptionBindingSource.EndEdit();
            quotation_DescriptionBindingSource.RemoveCurrent();
            quotation_DescriptionTableAdapter.Update(transnational_Auto_3DataSet.Quotation_Description);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);

        }

        private void QUOTATION_DESCRIPTION_DATA_ERROR(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("There is error in some of the data you provided. Check the format of your data");
        }

      

        private void btndeletequote_CLick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete, this quotation record from your system? Your invoices might not tally. ","Confirm" +
                "",MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                int quote_number = Int32.Parse(quote_numberTextBox.Text);
                //delete
                quotationBindingSource.RemoveCurrent();
                quotationBindingSource.EndEdit();
                quotation_DescriptionTableAdapter.DeleteQuotation(quote_number);
                quotationTableAdapter.Update(transnational_Auto_3DataSet);

                tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
                MessageBox.Show("Quotation record deleted", "Done");
            }
           
        }
        string regnumber;
        int customer_number, quote_number;
        private void btnQuoationPrint_Click(object sender, EventArgs e)
        {
           
              customer_number = Int32.Parse(txtcust_id.Text);
                quote_number = Int32.Parse(quote_numberTextBox.Text);
                regnumber = txtveh_regnumber.Text;
                PrintQuotatonForm quotefrm = new PrintQuotatonForm();
            quotefrm.QuotationQuery(regnumber, customer_number, quote_number);
            quotefrm.Show();
          
        }
    }
}
