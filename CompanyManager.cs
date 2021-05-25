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
    public partial class CompanyManager : Form
    {
        public CompanyManager()
        {
            InitializeComponent();
        }

        private void servicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        public void loadData()
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.transnational_Auto_3DataSet.Positions);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Authentication' table. You can move, or remove it, as needed.
            this.authenticationTableAdapter.Fill(this.transnational_Auto_3DataSet.Authentication);
            //-----------------------------before load
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.ServicesSubCategories' table. You can move, or remove it, as needed.
            this.servicesSubCategoriesTableAdapter.Fill(this.transnational_Auto_3DataSet.ServicesSubCategories);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.transnational_Auto_3DataSet.Services);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.transnational_Auto_3DataSet.Employees);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Authentication' table. You can move, or remove it, as needed.
         
            this.salaryTableAdapter.Fill(this.transnational_Auto_3DataSet.Salary);

        }
        private void CompayManager_Load(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 5;
            timer1.Start();
            
            loadData(); 
        }

        private void btnservices_Click(object sender, EventArgs e)
        {
   
        }

       
        private void btnnewservice_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.ShowDialog();

            servicesTableAdapter.Fill(this.transnational_Auto_3DataSet.Services);
        }

        private void btnSearch_Service_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = "description like '%" + txtsearch_service.Text + "%' ";
                servicesSubCategoriesBindingSource.Filter = filter;
            }
            catch
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesSubCategoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
        }

        private void txtsearch_service_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch_service.Text.Length < 3)
            {
                servicesSubCategoriesBindingSource.RemoveFilter();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void btndeleteSelected_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)servicesSubCategoriesDataGridView.CurrentRow.Cells[0].Value;
                int service_id = (int)servicesSubCategoriesDataGridView.CurrentRow.Cells[1].Value;
                double price = (double)servicesSubCategoriesDataGridView.CurrentRow.Cells[3].Value;
                servicesSubCategoriesTableAdapter.Delete(id, service_id, price);
            }
            catch
            {

            }
            loadData();
        }

        private void btnneewemployee_Click(object sender, EventArgs e)
        {
            employeesBindingSource.AddNew();
            company_codeTextBox.Text = "1";
        }

        private void btnsaveemployee_Click(object sender, EventArgs e)
        {
            this.Validate();
            employeesBindingSource.EndEdit();
            employeesTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
            loadData();
        }

        private void btndeleteemployee_Click(object sender, EventArgs e)
        {
            emp_codeTextBox.Clear();
            employeesBindingSource.RemoveCurrent();
          
            employeesBindingSource.EndEdit();
            employeesTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
            loadData();
            this.Refresh();
            
        }

        private void btnnewsalary_Click(object sender, EventArgs e)
        {
            salaryBindingSource.AddNew();
            emp_codeTextBox1.Text = emp_codeTextBox1.Text;
        }

        private void gross_adjustmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double gross = double.Parse(gross_salaryTextBox.Text);
                double adjustment = double.Parse(gross_adjustmentTextBox.Text);

                double net_salary = gross - adjustment;
                net_salaryTextBox.Text = Math.Round(net_salary,2).ToString();
               
            }
            catch
            {

            }
        }

        private void gross_salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double gross = double.Parse(gross_salaryTextBox.Text);
                double adjustment = double.Parse(gross_adjustmentTextBox.Text);

                double net_salary = gross - adjustment;
                net_salaryTextBox.Text = Math.Round(net_salary, 2).ToString();
               
            }
            catch
            {

            }
        }

        private void btnsave_salary_CLick(object sender, EventArgs e)
        {
            this.Validate();
            salaryBindingSource.EndEdit();
            try
            {
                salaryTableAdapter.Update(transnational_Auto_3DataSet);
            }
            catch
            {
                MessageBox.Show("The employee code " + emp_codeTextBox1.Text + " is not in the system. Check again");
            }
            tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
            loadData();
        }

        private void btnaddpicture_authenitcation_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Scanned Images  (*.png) ;(*.jpg); (*.jpeg);| *.png; *.jpeg; *jpg";
                opf.Title = "Choose a scanned picture or normal picture of signature";
                opf.ShowDialog();
                string picture = opf.FileName;
                contentsPictureBox.Image = Image.FromFile(picture);
            }
            catch(Exception pictre)
            {
                MessageBox.Show(pictre.Message +  " \n \n " + pictre.StackTrace)
;            }
        }

        private void btnSaveAuthentication(object sender, EventArgs e)
        {
            this.Validate();
            authenticationBindingSource.EndEdit();
            try
            {
                authenticationTableAdapter.Update(transnational_Auto_3DataSet);
            }
            catch
            {
                MessageBox.Show("The employee code " + employee_codeTextBox.Text + " is not in the system. Check again");
            }
            tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
            loadData();
        }

        private void newAuthenticaion(object sender, EventArgs e)
        {
            authenticationBindingSource.AddNew();
            company_codeTextBox1.Text = "1";
        }

        private void getPicture(object sender, EventArgs e)
        {
            if(authenticationdataGrid.CurrentCell == authenticationdataGrid.CurrentRow.Cells[0] &&company_codeTextBox1.Text != "" &&
                authenticationdataGrid.CurrentRow.Index <authenticationdataGrid.Rows.Count )
            {
               int id = Int32.Parse(idTextBox1.Text);
                CurrentImage.imageID(id);
                CurrentImage cr = new CurrentImage();
                cr.ShowDialog();
            }
            
        }

        private void btnnewposition_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = PositionsdataGridView.Rows.Count;
                positionsBindingSource.AddNew();
                PositionsdataGridView.Rows[rows - 1].Cells[2].Value = 1;
            }
            catch
            {
                MessageBox.Show("Finish adding this position first");
            }
        }

        private void btnsaveposition_Click(object sender, EventArgs e)
        {
            positionsBindingSource.EndEdit();
            try
            {
                positionsTableAdapter.Update(transnational_Auto_3DataSet);
            }
            catch
            {
                MessageBox.Show("The employee code  is not in the system. Check again");
            }
            tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
            loadData();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Finance_Manager fm = new Finance_Manager();
            fm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockManager sm = new StockManager();
            sm.ShowDialog();
        }

        private void Sevice_ID(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 5;
        }

        private void btnemployees_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 1;
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 2;
        }

        private void btnpositions_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 4;
        }

        private void btnservices_Click_1(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 0;

        }

        private void btnauth_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 3;
        }

        private void btninvoice_man_Click(object sender, EventArgs e)
        {
            Invoices_2 inv_2 = new Invoices_2();
            inv_2.Show();
        }

        private void btnquotation_man_Click(object sender, EventArgs e)
        {
            Quotations quotations = new Quotations();
            quotations.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void btnvehicle_Click(object sender, EventArgs e)
        {
            Customer_Vehicles vehicles_ = new Customer_Vehicles();
            vehicles_.Show();
        }

        public void orangeButton(Button button)
        {
            button.BackColor = Color.Orange;
            button.ForeColor = Color.White;
        }
        public void normalButton(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.FromArgb(93,93,93);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           if(xuiFlatTab1.SelectedIndex == 0)
            {
                orangeButton(btnservices);

            }
           else
            {
                normalButton(btnservices);
            }
            ///////
            ///
            if (xuiFlatTab1.SelectedIndex == 1)
            {
                orangeButton(btnemployees);

            }
            else
            {
                normalButton(btnemployees);
            }

            if (xuiFlatTab1.SelectedIndex == 2)
            {
                orangeButton(btnpayroll);

            }
            else
            {
                normalButton(btnpayroll);
            }

            if (xuiFlatTab1.SelectedIndex == 3)
            {
                orangeButton(btnauth);

            }
            else
            {
                normalButton(btnauth);
            }

            if (xuiFlatTab1.SelectedIndex == 4)
            {
                orangeButton(btnpositions);

            }
            else
            {
                normalButton(btnpositions);
            }

            if (xuiFlatTab1.SelectedIndex == 5)
            {
                orangeButton(btndashboard);

            }
            else
            {
                normalButton(btndashboard);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
           

        }
    }
}
