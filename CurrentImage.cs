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
    public partial class CurrentImage : Form
    {
        public CurrentImage()
        {
            InitializeComponent();
        }

        private void authenticationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authenticationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transnational_Auto_3DataSet);

        }
        static int image_id;
       static  public void imageID(int id)
        {
            image_id = id;
        }
        private void CurrentImage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transnational_Auto_3DataSet.Authentication' table. You can move, or remove it, as needed.
            //this.authenticationTableAdapter.FillByID(this.transnational_Auto_3DataSet.Authentication, image_id);

        }
    }
}
