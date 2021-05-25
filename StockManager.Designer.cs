namespace Transnational_Auto_3
{
    partial class StockManager
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManager));
            this.btndeleteSelected = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsaveStocks = new System.Windows.Forms.Button();
            this.btnnewservice = new System.Windows.Forms.Button();
            this.btnSearch_stock = new System.Windows.Forms.Button();
            this.txtsearch_stock = new System.Windows.Forms.TextBox();
            this.servicesSubCategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.stockdatagrid = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTypesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.StockTypesTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            this.stockTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.StockTableAdapter();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.btnimage_stock = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesSubCategoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.ForeColor = System.Drawing.Color.Black;
            descriptionLabel.Location = new System.Drawing.Point(10, 37);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 19);
            descriptionLabel.TabIndex = 19;
            descriptionLabel.Text = "Stock Family";
            // 
            // imageLabel
            // 
            imageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(12, 308);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(86, 19);
            imageLabel.TabIndex = 27;
            imageLabel.Text = "Stock Picture";
            // 
            // btndeleteSelected
            // 
            this.btndeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeleteSelected.BackColor = System.Drawing.SystemColors.Window;
            this.btndeleteSelected.FlatAppearance.BorderSize = 0;
            this.btndeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteSelected.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btndeleteSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btndeleteSelected.Location = new System.Drawing.Point(849, 684);
            this.btndeleteSelected.Name = "btndeleteSelected";
            this.btndeleteSelected.Size = new System.Drawing.Size(122, 25);
            this.btndeleteSelected.TabIndex = 27;
            this.btndeleteSelected.Text = "Delete selected";
            this.btndeleteSelected.UseVisualStyleBackColor = false;
            this.btndeleteSelected.Click += new System.EventHandler(this.btndeleteSelected_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnrefresh.FlatAppearance.BorderSize = 0;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnrefresh.Location = new System.Drawing.Point(977, 28);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 25);
            this.btnrefresh.TabIndex = 26;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsaveStocks
            // 
            this.btnsaveStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsaveStocks.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsaveStocks.FlatAppearance.BorderSize = 0;
            this.btnsaveStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveStocks.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnsaveStocks.ForeColor = System.Drawing.Color.White;
            this.btnsaveStocks.Location = new System.Drawing.Point(977, 684);
            this.btnsaveStocks.Name = "btnsaveStocks";
            this.btnsaveStocks.Size = new System.Drawing.Size(75, 25);
            this.btnsaveStocks.TabIndex = 24;
            this.btnsaveStocks.Text = "Save data";
            this.btnsaveStocks.UseVisualStyleBackColor = false;
            this.btnsaveStocks.Click += new System.EventHandler(this.btnsaveStocks_Click);
            // 
            // btnnewservice
            // 
            this.btnnewservice.BackColor = System.Drawing.Color.Orange;
            this.btnnewservice.FlatAppearance.BorderSize = 0;
            this.btnnewservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewservice.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnnewservice.ForeColor = System.Drawing.Color.White;
            this.btnnewservice.Location = new System.Drawing.Point(99, 34);
            this.btnnewservice.Name = "btnnewservice";
            this.btnnewservice.Size = new System.Drawing.Size(119, 25);
            this.btnnewservice.TabIndex = 23;
            this.btnnewservice.Text = "Add new &Stock Type";
            this.btnnewservice.UseVisualStyleBackColor = false;
            this.btnnewservice.Click += new System.EventHandler(this.btnnewservice_Click);
            // 
            // btnSearch_stock
            // 
            this.btnSearch_stock.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch_stock.FlatAppearance.BorderSize = 0;
            this.btnSearch_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_stock.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnSearch_stock.ForeColor = System.Drawing.Color.White;
            this.btnSearch_stock.Location = new System.Drawing.Point(627, 28);
            this.btnSearch_stock.Name = "btnSearch_stock";
            this.btnSearch_stock.Size = new System.Drawing.Size(75, 25);
            this.btnSearch_stock.TabIndex = 22;
            this.btnSearch_stock.Text = "Search";
            this.btnSearch_stock.UseVisualStyleBackColor = false;
            this.btnSearch_stock.Click += new System.EventHandler(this.btnSearch_stock_Click);
            // 
            // txtsearch_stock
            // 
            this.txtsearch_stock.Location = new System.Drawing.Point(347, 28);
            this.txtsearch_stock.Name = "txtsearch_stock";
            this.txtsearch_stock.Size = new System.Drawing.Size(274, 25);
            this.txtsearch_stock.TabIndex = 21;
            this.txtsearch_stock.TextChanged += new System.EventHandler(this.txtsearch_stock_TextChanged);
            // 
            // servicesSubCategoriesDataGridView
            // 
            this.servicesSubCategoriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesSubCategoriesDataGridView.AutoGenerateColumns = false;
            this.servicesSubCategoriesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.servicesSubCategoriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesSubCategoriesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.servicesSubCategoriesDataGridView.ColumnHeadersHeight = 30;
            this.servicesSubCategoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.companycodeDataGridViewTextBoxColumn,
            this.typecodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.imageDataGridViewImageColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.servicesSubCategoriesDataGridView.DataSource = this.stockBindingSource;
            this.servicesSubCategoriesDataGridView.EnableHeadersVisualStyles = false;
            this.servicesSubCategoriesDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.servicesSubCategoriesDataGridView.Location = new System.Drawing.Point(347, 59);
            this.servicesSubCategoriesDataGridView.Name = "servicesSubCategoriesDataGridView";
            this.servicesSubCategoriesDataGridView.RowHeadersVisible = false;
            this.servicesSubCategoriesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.servicesSubCategoriesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.servicesSubCategoriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesSubCategoriesDataGridView.Size = new System.Drawing.Size(705, 619);
            this.servicesSubCategoriesDataGridView.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // companycodeDataGridViewTextBoxColumn
            // 
            this.companycodeDataGridViewTextBoxColumn.DataPropertyName = "company_code";
            this.companycodeDataGridViewTextBoxColumn.HeaderText = "ComCode";
            this.companycodeDataGridViewTextBoxColumn.Name = "companycodeDataGridViewTextBoxColumn";
            // 
            // typecodeDataGridViewTextBoxColumn
            // 
            this.typecodeDataGridViewTextBoxColumn.DataPropertyName = "type_code";
            this.typecodeDataGridViewTextBoxColumn.HeaderText = "TypeCode";
            this.typecodeDataGridViewTextBoxColumn.Name = "typecodeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "FK_Stock_StockTypes";
            this.stockBindingSource.DataSource = this.stockTypesBindingSource;
            // 
            // stockTypesBindingSource
            // 
            this.stockTypesBindingSource.DataMember = "StockTypes";
            this.stockTypesBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockdatagrid
            // 
            this.stockdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stockdatagrid.AutoGenerateColumns = false;
            this.stockdatagrid.BackgroundColor = System.Drawing.Color.White;
            this.stockdatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockdatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stockdatagrid.ColumnHeadersHeight = 30;
            this.stockdatagrid.ColumnHeadersVisible = false;
            this.stockdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn});
            this.stockdatagrid.DataSource = this.stockTypesBindingSource;
            this.stockdatagrid.EnableHeadersVisualStyles = false;
            this.stockdatagrid.GridColor = System.Drawing.Color.White;
            this.stockdatagrid.Location = new System.Drawing.Point(12, 65);
            this.stockdatagrid.Name = "stockdatagrid";
            this.stockdatagrid.ReadOnly = true;
            this.stockdatagrid.RowHeadersVisible = false;
            this.stockdatagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.stockdatagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.stockdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockdatagrid.Size = new System.Drawing.Size(305, 240);
            this.stockdatagrid.TabIndex = 25;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockTypesTableAdapter
            // 
            this.stockTypesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.StockTypesTableAdapter = this.stockTypesTableAdapter;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imagePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.stockBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(14, 330);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(266, 286);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 28;
            this.imagePictureBox.TabStop = false;
            // 
            // btnimage_stock
            // 
            this.btnimage_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimage_stock.BackColor = System.Drawing.Color.White;
            this.btnimage_stock.FlatAppearance.BorderSize = 0;
            this.btnimage_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimage_stock.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnimage_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnimage_stock.Location = new System.Drawing.Point(28, 582);
            this.btnimage_stock.Name = "btnimage_stock";
            this.btnimage_stock.Size = new System.Drawing.Size(235, 25);
            this.btnimage_stock.TabIndex = 23;
            this.btnimage_stock.Text = "Add &Image";
            this.btnimage_stock.UseVisualStyleBackColor = false;
            this.btnimage_stock.Click += new System.EventHandler(this.btnstock_click);
            // 
            // StockManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.btndeleteSelected);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnsaveStocks);
            this.Controls.Add(this.btnimage_stock);
            this.Controls.Add(this.btnnewservice);
            this.Controls.Add(this.btnSearch_stock);
            this.Controls.Add(this.txtsearch_stock);
            this.Controls.Add(this.servicesSubCategoriesDataGridView);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.stockdatagrid);
            this.Controls.Add(this.imagePictureBox);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockManager";
            this.ShowIcon = false;
            this.Text = "StockManager";
            this.Load += new System.EventHandler(this.StockManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesSubCategoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndeleteSelected;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsaveStocks;
        private System.Windows.Forms.Button btnnewservice;
        private System.Windows.Forms.Button btnSearch_stock;
        private System.Windows.Forms.TextBox txtsearch_stock;
        private System.Windows.Forms.DataGridView servicesSubCategoriesDataGridView;
        private System.Windows.Forms.DataGridView stockdatagrid;
        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource stockTypesBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.StockTypesTableAdapter stockTypesTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Transnational_Auto_3DataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button btnimage_stock;
    }
}