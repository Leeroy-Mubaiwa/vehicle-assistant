namespace Transnational_Auto_3
{
    partial class Services
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label company_codeLabel;
            System.Windows.Forms.Label services_idLabel;
            this.servicesDatagridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.servicesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.company_codeTextBox = new System.Windows.Forms.TextBox();
            this.btnservices = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.btnnewservice = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.servicesSubCategoriesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.ServicesSubCategoriesTableAdapter();
            this.services_idLabel1 = new System.Windows.Forms.Label();
            this.servicesSubCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            company_codeLabel = new System.Windows.Forms.Label();
            services_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesSubCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(119, 67);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(72, 19);
            idLabel.TabIndex = 4;
            idLabel.Text = "Service ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(119, 100);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(80, 19);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // company_codeLabel
            // 
            company_codeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            company_codeLabel.AutoSize = true;
            company_codeLabel.Location = new System.Drawing.Point(119, 131);
            company_codeLabel.Name = "company_codeLabel";
            company_codeLabel.Size = new System.Drawing.Size(101, 19);
            company_codeLabel.TabIndex = 8;
            company_codeLabel.Text = "company code:";
            // 
            // services_idLabel
            // 
            services_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            services_idLabel.AutoSize = true;
            services_idLabel.Location = new System.Drawing.Point(10, 560);
            services_idLabel.Name = "services_idLabel";
            services_idLabel.Size = new System.Drawing.Size(75, 19);
            services_idLabel.TabIndex = 13;
            services_idLabel.Text = "services id:";
            // 
            // servicesDatagridView
            // 
            this.servicesDatagridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesDatagridView.AutoGenerateColumns = false;
            this.servicesDatagridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.servicesDatagridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesDatagridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.servicesDatagridView.ColumnHeadersHeight = 30;
            this.servicesDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.companycodeDataGridViewTextBoxColumn});
            this.servicesDatagridView.DataSource = this.servicesBindingSource;
            this.servicesDatagridView.EnableHeadersVisualStyles = false;
            this.servicesDatagridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.servicesDatagridView.Location = new System.Drawing.Point(16, 209);
            this.servicesDatagridView.Name = "servicesDatagridView";
            this.servicesDatagridView.RowHeadersVisible = false;
            this.servicesDatagridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.servicesDatagridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.servicesDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDatagridView.Size = new System.Drawing.Size(900, 291);
            this.servicesDatagridView.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Service Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // companycodeDataGridViewTextBoxColumn
            // 
            this.companycodeDataGridViewTextBoxColumn.DataPropertyName = "company_code";
            this.companycodeDataGridViewTextBoxColumn.HeaderText = "Company Code";
            this.companycodeDataGridViewTextBoxColumn.Name = "companycodeDataGridViewTextBoxColumn";
            this.companycodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StockTypesTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.BackColor = System.Drawing.Color.White;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(226, 64);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(121, 25);
            this.idTextBox.TabIndex = 5;
            // 
            // company_codeTextBox
            // 
            this.company_codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.company_codeTextBox.BackColor = System.Drawing.Color.White;
            this.company_codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.company_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "company_code", true));
            this.company_codeTextBox.Location = new System.Drawing.Point(226, 128);
            this.company_codeTextBox.Name = "company_codeTextBox";
            this.company_codeTextBox.ReadOnly = true;
            this.company_codeTextBox.Size = new System.Drawing.Size(121, 25);
            this.company_codeTextBox.TabIndex = 9;
            // 
            // btnservices
            // 
            this.btnservices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnservices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnservices.FlatAppearance.BorderSize = 0;
            this.btnservices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnservices.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnservices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnservices.Location = new System.Drawing.Point(272, 159);
            this.btnservices.Name = "btnservices";
            this.btnservices.Size = new System.Drawing.Size(75, 29);
            this.btnservices.TabIndex = 10;
            this.btnservices.Text = "Save";
            this.btnservices.UseVisualStyleBackColor = false;
            this.btnservices.Click += new System.EventHandler(this.btnservices_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(226, 95);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(349, 25);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // btnnewservice
            // 
            this.btnnewservice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnnewservice.BackColor = System.Drawing.Color.White;
            this.btnnewservice.FlatAppearance.BorderSize = 0;
            this.btnnewservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewservice.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnnewservice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(155)))), ((int)(((byte)(235)))));
            this.btnnewservice.Location = new System.Drawing.Point(226, 33);
            this.btnnewservice.Name = "btnnewservice";
            this.btnnewservice.Size = new System.Drawing.Size(121, 25);
            this.btnnewservice.TabIndex = 12;
            this.btnnewservice.Text = "Add new service";
            this.btnnewservice.UseVisualStyleBackColor = false;
            this.btnnewservice.Click += new System.EventHandler(this.btnnewservice_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnreturn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnreturn.FlatAppearance.BorderSize = 0;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Location = new System.Drawing.Point(743, 506);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(173, 29);
            this.btnreturn.TabIndex = 13;
            this.btnreturn.Text = "Save all and return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.button1.Location = new System.Drawing.Point(564, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // servicesSubCategoriesTableAdapter
            // 
            this.servicesSubCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // services_idLabel1
            // 
            this.services_idLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.services_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesSubCategoriesBindingSource, "services_id", true));
            this.services_idLabel1.Location = new System.Drawing.Point(91, 560);
            this.services_idLabel1.Name = "services_idLabel1";
            this.services_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.services_idLabel1.TabIndex = 14;
            this.services_idLabel1.Text = "label1";
            // 
            // servicesSubCategoriesBindingSource
            // 
            this.servicesSubCategoriesBindingSource.DataMember = "FK_ServicesSubCategories_Services";
            this.servicesSubCategoriesBindingSource.DataSource = this.servicesBindingSource;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Location = new System.Drawing.Point(564, 178);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(349, 25);
            this.txtsearch.TabIndex = 15;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 588);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(services_idLabel);
            this.Controls.Add(this.services_idLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnnewservice);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.btnservices);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(company_codeLabel);
            this.Controls.Add(this.company_codeTextBox);
            this.Controls.Add(this.servicesDatagridView);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Services";
            this.ShowIcon = false;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesSubCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView servicesDatagridView;
        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox company_codeTextBox;
        private System.Windows.Forms.Button btnservices;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnnewservice;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource servicesSubCategoriesBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.ServicesSubCategoriesTableAdapter servicesSubCategoriesTableAdapter;
        private System.Windows.Forms.Label services_idLabel1;
        private System.Windows.Forms.TextBox txtsearch;
    }
}