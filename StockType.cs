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
    public partial class StockType : Form
    {
        public StockType()
        {
            InitializeComponent();
        }

        private void StockType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.StockTypes' table. You can move, or remove it, as needed.
            this.stockTypesTableAdapter.Fill(this.transnational_Auto_3DataSet.StockTypes);

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);
            this.Close();
        }

        private void btnaddstock_Click(object sender, EventArgs e)
        {
            stockTypesBindingSource.AddNew();
        }

        private void btndeletestock_Click(object sender, EventArgs e)
        {
            stockTypesBindingSource.RemoveCurrent();
            stockTypesBindingSource.EndEdit();
            stockTypesTableAdapter.Update(transnational_Auto_3DataSet);
            tableAdapterManager.UpdateAll(transnational_Auto_3DataSet);
        }
    }
}
