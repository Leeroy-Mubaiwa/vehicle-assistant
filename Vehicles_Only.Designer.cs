namespace Transnational_Auto_3
{
    partial class Vehicles_Only
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vehiclesDatagridView = new System.Windows.Forms.DataGridView();
            this.vehiclesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chasisnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnsaveall = new System.Windows.Forms.Button();
            this.vehiclesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesDatagridView
            // 
            this.vehiclesDatagridView.AllowUserToAddRows = false;
            this.vehiclesDatagridView.AutoGenerateColumns = false;
            this.vehiclesDatagridView.BackgroundColor = System.Drawing.Color.White;
            this.vehiclesDatagridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehiclesDatagridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vehiclesDatagridView.ColumnHeadersHeight = 40;
            this.vehiclesDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehiclesidDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.custidDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.enginenumberDataGridViewTextBoxColumn,
            this.chasisnumberDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.mileageinDataGridViewTextBoxColumn,
            this.mileageoutDataGridViewTextBoxColumn,
            this.fuelinDataGridViewTextBoxColumn});
            this.vehiclesDatagridView.DataSource = this.vehiclesBindingSource;
            this.vehiclesDatagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiclesDatagridView.EnableHeadersVisualStyles = false;
            this.vehiclesDatagridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.vehiclesDatagridView.Location = new System.Drawing.Point(0, 54);
            this.vehiclesDatagridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vehiclesDatagridView.Name = "vehiclesDatagridView";
            this.vehiclesDatagridView.RowHeadersVisible = false;
            this.vehiclesDatagridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.vehiclesDatagridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.vehiclesDatagridView.RowTemplate.DividerHeight = 5;
            this.vehiclesDatagridView.RowTemplate.Height = 40;
            this.vehiclesDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehiclesDatagridView.Size = new System.Drawing.Size(1064, 667);
            this.vehiclesDatagridView.TabIndex = 7;
            // 
            // vehiclesidDataGridViewTextBoxColumn
            // 
            this.vehiclesidDataGridViewTextBoxColumn.DataPropertyName = "vehicles_id";
            this.vehiclesidDataGridViewTextBoxColumn.HeaderText = "vehicles_id";
            this.vehiclesidDataGridViewTextBoxColumn.Name = "vehiclesidDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Image = global::Transnational_Auto_3.Properties.Resources.LogoAuto;
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "cust_id";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "Registration Number";
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            // 
            // enginenumberDataGridViewTextBoxColumn
            // 
            this.enginenumberDataGridViewTextBoxColumn.DataPropertyName = "engine_number";
            this.enginenumberDataGridViewTextBoxColumn.HeaderText = "Engine Number";
            this.enginenumberDataGridViewTextBoxColumn.Name = "enginenumberDataGridViewTextBoxColumn";
            // 
            // chasisnumberDataGridViewTextBoxColumn
            // 
            this.chasisnumberDataGridViewTextBoxColumn.DataPropertyName = "chasis_number";
            this.chasisnumberDataGridViewTextBoxColumn.HeaderText = "Chasis Number";
            this.chasisnumberDataGridViewTextBoxColumn.Name = "chasisnumberDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // mileageinDataGridViewTextBoxColumn
            // 
            this.mileageinDataGridViewTextBoxColumn.DataPropertyName = "mileage_in";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            this.mileageinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.mileageinDataGridViewTextBoxColumn.HeaderText = "Mileage in";
            this.mileageinDataGridViewTextBoxColumn.Name = "mileageinDataGridViewTextBoxColumn";
            // 
            // mileageoutDataGridViewTextBoxColumn
            // 
            this.mileageoutDataGridViewTextBoxColumn.DataPropertyName = "mileage_out";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Tomato;
            this.mileageoutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.mileageoutDataGridViewTextBoxColumn.HeaderText = "Mileage Out";
            this.mileageoutDataGridViewTextBoxColumn.Name = "mileageoutDataGridViewTextBoxColumn";
            // 
            // fuelinDataGridViewTextBoxColumn
            // 
            this.fuelinDataGridViewTextBoxColumn.DataPropertyName = "fuel_in";
            this.fuelinDataGridViewTextBoxColumn.HeaderText = "Fuel in";
            this.fuelinDataGridViewTextBoxColumn.Name = "fuelinDataGridViewTextBoxColumn";
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.btnsaveall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 54);
            this.panel1.TabIndex = 8;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsearch.Location = new System.Drawing.Point(61, 13);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(262, 25);
            this.txtsearch.TabIndex = 18;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btndelete.Location = new System.Drawing.Point(780, 13);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(133, 25);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnsearch.Location = new System.Drawing.Point(329, 13);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(133, 25);
            this.btnsearch.TabIndex = 16;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnsaveall
            // 
            this.btnsaveall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsaveall.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsaveall.FlatAppearance.BorderSize = 0;
            this.btnsaveall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveall.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnsaveall.ForeColor = System.Drawing.Color.White;
            this.btnsaveall.Location = new System.Drawing.Point(919, 13);
            this.btnsaveall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsaveall.Name = "btnsaveall";
            this.btnsaveall.Size = new System.Drawing.Size(133, 25);
            this.btnsaveall.TabIndex = 17;
            this.btnsaveall.Text = "Save All Data";
            this.btnsaveall.UseVisualStyleBackColor = false;
            this.btnsaveall.Click += new System.EventHandler(this.btnsaveall_Click);
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthenticationTableAdapter = null;
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
            this.tableAdapterManager.VehiclesTableAdapter = this.vehiclesTableAdapter;
            // 
            // Vehicles_Only
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.vehiclesDatagridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vehicles_Only";
            this.ShowIcon = false;
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Only_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vehiclesDatagridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnsaveall;
        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiclesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chasisnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelinDataGridViewTextBoxColumn;
    }
}