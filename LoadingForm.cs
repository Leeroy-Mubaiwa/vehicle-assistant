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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  timer1.Start();
            backgroundWorker1.RunWorkerAsync();
        }
       
        public void load()
        {
            Invoke(new Action(() =>
            {
                panel1.Left++;
            }));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
           // int t = 2;
          
                
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            load();
        }
    }
}
