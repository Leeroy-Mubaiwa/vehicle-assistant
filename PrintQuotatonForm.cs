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
    public partial class PrintQuotatonForm : Form
    {
        public PrintQuotatonForm()
        {
            InitializeComponent();
        }
        string reg_number;
        int customerid, quotationnum;
        public void QuotationQuery(string regnumber, int cust_id, int quote_num )
        {
            customerid = cust_id;
            quotationnum = quote_num;
            reg_number = regnumber;

        }
            
        private void PrintQuotatonForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Transnational_Auto_3DataSet.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.FillByPrint(this.Transnational_Auto_3DataSet.Customers,customerid);
            // TODO: This line of code loads data into the 'Transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.VehiclesTableAdapter.FillByPrint(this.Transnational_Auto_3DataSet.Vehicles,reg_number);
            // TODO: This line of code loads data into the 'Transnational_Auto_3DataSet.Quotation' table. You can move, or remove it, as needed.
            this.QuotationTableAdapter.FillByPrint(this.Transnational_Auto_3DataSet.Quotation,quotationnum);
            // TODO: This line of code loads data into the 'Transnational_Auto_3DataSet.Quotation_Description' table. You can move, or remove it, as needed.
            this.Quotation_DescriptionTableAdapter.FillByPrint(this.Transnational_Auto_3DataSet.Quotation_Description,quotationnum);
            progressBar2.Style = ProgressBarStyle.Marquee;
            timer1.Start();
            // progressBar1.Visible = false;
            backgroundWorker1.RunWorkerAsync();
        }
        bool loaded = false;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            loadReport();

            {
                if (loadReport() == true)
                {
                    Invoke(new Action(() =>
                    {


                        progressBar2.Visible = false;
                    }));

                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }

        public bool loadReport()
        {

            //for (int b = 0; b < 100;b++)
            {
                try
                {


                    Invoke(new Action(() =>
                    {
                        this.reportViewer1.RefreshReport();
                    }));
                    loaded = true;

                    return true;

                }
                catch
                {
                    return false;
                }
            }
            //            return false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (loaded == true)
            {
                lblWaiting.Visible = false;
                timer1.Stop();
                progressBar1.Visible = false;
            }
            else
            {
                if (counter % 100 == 0)
                {
                    label1.Text = "Click the green button to refresh";
                }
                else
                {
                    label1.Text = "Loading please wait";
                    counter++;
                }
            }
        }

        int counter = 0;

    }
}
