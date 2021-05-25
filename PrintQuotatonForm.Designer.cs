namespace Transnational_Auto_3
{
    partial class PrintQuotatonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource16 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.VehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuotationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quotation_DescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomersTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.CustomersTableAdapter();
            this.VehiclesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter();
            this.QuotationTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.QuotationTableAdapter();
            this.Quotation_DescriptionTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.Quotation_DescriptionTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transnational_Auto_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuotationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotation_DescriptionBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.Transnational_Auto_3DataSet;
            // 
            // Transnational_Auto_3DataSet
            // 
            this.Transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.Transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VehiclesBindingSource
            // 
            this.VehiclesBindingSource.DataMember = "Vehicles";
            this.VehiclesBindingSource.DataSource = this.Transnational_Auto_3DataSet;
            // 
            // QuotationBindingSource
            // 
            this.QuotationBindingSource.DataMember = "Quotation";
            this.QuotationBindingSource.DataSource = this.Transnational_Auto_3DataSet;
            // 
            // Quotation_DescriptionBindingSource
            // 
            this.Quotation_DescriptionBindingSource.DataMember = "Quotation_Description";
            this.Quotation_DescriptionBindingSource.DataSource = this.Transnational_Auto_3DataSet;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar2.Location = new System.Drawing.Point(432, 340);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(124, 23);
            this.progressBar2.TabIndex = 12;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.BackColor = System.Drawing.Color.White;
            this.lblWaiting.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lblWaiting.ForeColor = System.Drawing.Color.Gray;
            this.lblWaiting.Location = new System.Drawing.Point(428, 377);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(128, 19);
            this.lblWaiting.TabIndex = 11;
            this.lblWaiting.Text = "Loading please wait";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource13.Name = "CustomersSet";
            reportDataSource13.Value = this.CustomersBindingSource;
            reportDataSource14.Name = "VehiclesSet";
            reportDataSource14.Value = this.VehiclesBindingSource;
            reportDataSource15.Name = "QuoteSet";
            reportDataSource15.Value = this.QuotationBindingSource;
            reportDataSource16.Name = "DescriptionSet";
            reportDataSource16.Value = this.Quotation_DescriptionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource16);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Transnational_Auto_3.QuotationReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(94, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(806, 498);
            this.reportViewer1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(94, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 45);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loading please wait";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(662, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "ReCompile Quotation";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 543);
            this.panel1.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(900, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 543);
            this.panel2.TabIndex = 9;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // VehiclesTableAdapter
            // 
            this.VehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // QuotationTableAdapter
            // 
            this.QuotationTableAdapter.ClearBeforeFill = true;
            // 
            // Quotation_DescriptionTableAdapter
            // 
            this.Quotation_DescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrintQuotatonForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(988, 543);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.Name = "PrintQuotatonForm";
            this.Text = "PrintQuotatonForm";
            this.Load += new System.EventHandler(this.PrintQuotatonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transnational_Auto_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuotationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotation_DescriptionBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblWaiting;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private Transnational_Auto_3DataSet Transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource VehiclesBindingSource;
        private System.Windows.Forms.BindingSource QuotationBindingSource;
        private System.Windows.Forms.BindingSource Quotation_DescriptionBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter VehiclesTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.QuotationTableAdapter QuotationTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.Quotation_DescriptionTableAdapter Quotation_DescriptionTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}