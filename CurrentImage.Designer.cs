namespace Transnational_Auto_3
{
    partial class CurrentImage
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
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.authenticationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticationTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.AuthenticationTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            this.contentsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authenticationBindingSource
            // 
            this.authenticationBindingSource.DataMember = "Authentication";
            this.authenticationBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // authenticationTableAdapter
            // 
            this.authenticationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthenticationTableAdapter = this.authenticationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Invoice_DescriptionTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.Quotation_DescriptionTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.SalaryTableAdapter = null;
            this.tableAdapterManager.ServicesSubCategoriesTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StockTypesTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // contentsPictureBox
            // 
            this.contentsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentsPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.authenticationBindingSource, "contents", true));
            this.contentsPictureBox.Location = new System.Drawing.Point(88, 29);
            this.contentsPictureBox.Name = "contentsPictureBox";
            this.contentsPictureBox.Size = new System.Drawing.Size(746, 433);
            this.contentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contentsPictureBox.TabIndex = 2;
            this.contentsPictureBox.TabStop = false;
            // 
            // CurrentImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(894, 532);
            this.Controls.Add(this.contentsPictureBox);
            this.Name = "CurrentImage";
            this.ShowIcon = false;
            this.Text = "CurrentImage";
            this.Load += new System.EventHandler(this.CurrentImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource authenticationBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.AuthenticationTableAdapter authenticationTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox contentsPictureBox;
    }
}