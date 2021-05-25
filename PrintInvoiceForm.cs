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
using System.Runtime.InteropServices;

namespace Transnational_Auto_3
{
    public partial class PrintInvoiceForm : Form
    {
       
        public PrintInvoiceForm()
        {
            InitializeComponent();
            

        }
        string regnumber_;
        int customernumber, invoicenumber;
        public void InvoiceQuery(string regnumber, int customer_number, int invoice_number)
        {
            regnumber_ = regnumber;
            customernumber = customer_number;
            invoicenumber = invoice_number;
        }
        private void PrintInvoiceForm_Load(object sender, EventArgs e)
        {

            //  Thread thread = new Thread(loadReport);
            // thread.Start();
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoice_Description' table. You can move, or remove it, as needed.
            this.invoice_DescriptionTableAdapter.FillByPrint(this.transnational_Auto_3DataSet.Invoice_Description, invoicenumber);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.FillByPrint(this.transnational_Auto_3DataSet.Vehicles, regnumber_);
            //reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.FillByPrint(this.transnational_Auto_3DataSet.Customers, customernumber);

            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.FillByPrint(this.transnational_Auto_3DataSet.Invoices, invoicenumber);
            progressBar2.Style = ProgressBarStyle.Marquee;
            timer1.Start();

           // progressBar1.Visible = false;
            backgroundWorker1.RunWorkerAsync();
        }
  
        bool loaded = false;
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
        private void button1_Click(object sender, EventArgs e)
        {
         
          
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
            loadReport();
           
            {
                if(loadReport() == true)
                {
                    Invoke(new Action(() =>
                    {


                        progressBar2.Visible = false;
                    } ));
                   
                }
            }


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }
        int counter=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(loaded == true)
            {
                lblWaiting.Visible = false;
                timer1.Stop();
                progressBar1.Visible = false;
            }
            else
            {
                if(counter%100 == 0)
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
    }
}
