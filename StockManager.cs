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
    public partial class StockManager : Form
    {
        public StockManager()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.transnational_Auto_3DataSet.Stock);
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.StockTypes' table. You can move, or remove it, as needed.
            this.stockTypesTableAdapter.Fill(this.transnational_Auto_3DataSet.StockTypes);
        }
        private void StockManager_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnnewservice_Click(object sender, EventArgs e)
        {
            StockType st = new StockType();
            st.ShowDialog();
            loadData();
        }

        private void btnSearch_stock_Click(object sender, EventArgs e)
        {
            stockBindingSource.Filter = "description like '%" + txtsearch_stock.Text + "%'";
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btndeleteSelected_Click(object sender, EventArgs e)
        {
            stockBindingSource.RemoveCurrent();
            stockBindingSource.EndEdit();
            stockTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
        }

        private void btnsaveStocks_Click(object sender, EventArgs e)
        {
            this.Validate();
            stockBindingSource.EndEdit();
            stockTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
        }

        private void btnstock_click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Scanned Images  (*.png) ;(*.jpg); (*.jpeg);| *.png; *.jpeg; *jpg";
                opf.Title = "Choose a scanned picture or normal picture of signature";
                opf.ShowDialog();
                string picture = opf.FileName;
                imagePictureBox.Image = Image.FromFile(picture);
            }
            catch (Exception pictre)
            {
                MessageBox.Show(pictre.Message + " \n \n " + pictre.StackTrace)
;
            }
        }

        private void txtsearch_stock_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch_stock.Text.Length<3)
            {
                this.stockBindingSource.RemoveFilter();
            }
        }
    }
}
