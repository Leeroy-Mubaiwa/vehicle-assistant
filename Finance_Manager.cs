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
    public partial class Finance_Manager : Form
    {
        public Finance_Manager()
        {
            InitializeComponent();
        }

       

        private void Finance_Manager_Load(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.transnational_Auto_3DataSet.Transactions);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.transnational_Auto_3DataSet.Transactions);
            timer_Balance.Start();
        
        }

        public void addDebits()
        {
            try
            {
                double selected= 0;
                double total_debit = 0;
              
                int debit_rows = transactionsdataGridView.Rows.Count;
                for (int a = 0; a < debit_rows-1; a++)
                {
                    try
                    {

                        selected = (double)transactionsdataGridView.Rows[a].Cells[5].Value;
                    }catch
                    {
                        transactionsdataGridView.Rows[a].Cells[5].Value = 0;
                        selected = 0;
                    }
                    
                    total_debit += selected;
                    btndebit.Text = Math.Round(total_debit,2).ToString();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        public void addCredits()
        {
            try
            {
                double selected = 0;
                double total_credit = 0;

                int credit_rows = transactionsdataGridView.Rows.Count;
                for (int a = 0; a < credit_rows - 1; a++)
                {
                    try
                    {

                        selected = (double)transactionsdataGridView.Rows[a].Cells[6].Value;
                    }
                    catch
                    {
                        transactionsdataGridView.Rows[a].Cells[6].Value = 0;
                        selected = 0;
                    }

                    total_credit += selected;
                    btncredit.Text = Math.Round(total_credit, 2).ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void btnsave_transactions_Click(object sender, EventArgs e)
        {
            this.Validate();
            transactionsBindingSource.EndEdit();
            transactionsTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);

            addDebits();
            addCredits();
            finalBalance();
        }
        public void finalBalance()
        {
            try
            {
                double total_c = double.Parse(btncredit.Text);
                double total_d = double.Parse(btndebit.Text);
                double final_t = total_d - total_c;

                if(final_t <= 0)
                {
                    btntotaldiff.BackColor = Color.FromArgb(255, 204, 0);
                }
                else
                {
                    btntotaldiff.BackColor = Color.FromArgb(84, 155, 235);
                }
                btntotaldiff.Text = Math.Round(final_t,2).ToString();
                
            }
            catch
            {

            }
        }
     
        private void timer_Balance_Tick(object sender, EventArgs e)
        {
            addCredits();
            addDebits();
            finalBalance();
          
            
              
           
        }
        public void addtoGraphs(double total)
        {
            
         

        }
    }
}
