using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transnational_Auto_3
{
    public partial class Invoices_2 : Form
    {
        public Invoices_2()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);

        }

        public void load()
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.transnational_Auto_3DataSet.Customers);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoice_Description' table. You can move, or remove it, as needed.
            this.invoice_DescriptionTableAdapter.Fill(this.transnational_Auto_3DataSet.Invoice_Description);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.transnational_Auto_3DataSet.Invoices);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.transnational_Auto_3DataSet.Vehicles);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Company' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.transnational_Auto_3DataSet.Vehicles);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoice_Description' table. You can move, or remove it, as needed.
            this.invoice_DescriptionTableAdapter.Fill(this.transnational_Auto_3DataSet.Invoice_Description);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.transnational_Auto_3DataSet.Invoices);
           
            Invoke(new Action(() =>
            {
                progressBar1.Visible = false;
            }));

        }
        ProgressBar progressBar1 = new ProgressBar();
        private void Invoices_2_Load(object sender, EventArgs e)
        {
         
            progressBar1.Parent = this;
            progressBar1.Left = 10;
            progressBar1.Top = 00;
            progressBar1.Style = ProgressBarStyle.Marquee;
            load();
          
            timer1.Start();
        }

        private void btnsave_all_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Validate();
            invoicesBindingSource.EndEdit();
            invoicesTableAdapter.Update(transnational_Auto_3DataSet.Invoices);
            invoice_DescriptionTableAdapter.Update(transnational_Auto_3DataSet.Invoice_Description);
                tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
          
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);

        }

        private void companyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
           
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);

        }

        private void vehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);

        }

        private void btnnewinvoice_Click(object sender, EventArgs e)
        {
            invoicesBindingSource.AddNew();
        }

        private void btndeleteinvoice_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete, this invoice record from your system? Your finances might not tally. ", "Confirm" +
              "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int inv_num = Int32.Parse(inv_numTextBox.Text);
                //delete
                invoicesBindingSource.RemoveCurrent();
                invoicesBindingSource.EndEdit();
                invoice_DescriptionTableAdapter.DeleteInvoice(inv_num);
                invoice_DescriptionTableAdapter.Update(transnational_Auto_3DataSet);

                tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
                MessageBox.Show("Invoice record deleted", "Done");
            }
        }

        private void btndeleteinvoice_description_Click(object sender, EventArgs e)
        {
            invoice_DescriptionBindingSource.RemoveCurrent();
            invoice_DescriptionBindingSource.EndEdit();
            invoice_DescriptionTableAdapter.Update(transnational_Auto_3DataSet.Invoice_Description);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            addTotal();
        }
        private void INVOICE_DESCRIPTION_DATA_ERROR(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("There is error in some of the data you provided. Check the format of your data");
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

                int rows = invoice_DescriptionDataGridView.Rows.Count;
                for (int a = 0; a < rows - 1; a++)
                {
                    try
                    {

                        selected_1 = (double)invoice_DescriptionDataGridView.Rows[a].Cells[4].Value;
                        selected_2 = (int)invoice_DescriptionDataGridView.Rows[a].Cells[2].Value;
                        selected_total = selected_1 * selected_2;
                    }
                    catch
                    {
                        // quotation_datagrid.Rows[a].Cells[5].Value = 0;
                        selected_total = 0;
                    }

                    total += selected_total;
                    invoice_DescriptionDataGridView.Rows[a].Cells[5].Value = selected_total;
                    btntotal_initial.Text = Math.Round(total, 2).ToString();
                    get_Final_Total(total);
                }
            }
            catch
            {
                // MessageBox.Show(er.Message);
            }
        }

        public void get_Final_Total(double total)
        {
            double vat_discount = total;

            //to know whether we add or subtract

            if (radioVAT.Checked == true)
            {
                //vat add
                float vat = float.Parse(txtvat.Text);
                double percentage_more = (vat / 100) * total;
                double final = total + percentage_more;
                btntotal.Text = final.ToString();
            }
            else if (radioDiscount.Checked == true)
            {
                //discount subtract
                float discount = float.Parse(txtvat.Text);
                double percentage_less = (discount / 100) * total;
                double final = total - percentage_less;
                btntotal.Text = final.ToString();
            }
            else
            {
                btntotal.Text = btntotal_initial.Text;
                txtdiscount.Text = "0";
            }
            totalTextBox.Text =  btntotal.Text;

        }
        private void invoice_DescriptionDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                //authenticationdataGrid.CurrentCell == authenticationdataGrid.CurrentRow.Cells[0] && company_codeTextBox1.Text != "" &&
                // authenticationdataGrid.CurrentRow.Index < authenticationdataGrid.Rows.Count
                if (invoice_DescriptionDataGridView.CurrentCell == invoice_DescriptionDataGridView.CurrentRow.Cells[1])
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

       

        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            txtdiscount.Text = txtvat.Text;
        }
        string regnumber;
        int customer_number, invoice_number;
        private void button1_Click(object sender, EventArgs e)
        {
            customer_number = Int32.Parse(cust_idTextBox.Text);
            invoice_number = Int32.Parse(inv_numTextBox.Text);
            regnumber = reg_numberTextBox.Text;
            PrintInvoiceForm printInvoiceForm = new PrintInvoiceForm();
            printInvoiceForm.InvoiceQuery(regnumber,customer_number,invoice_number);
            printInvoiceForm.Show();
        }
    }
}
